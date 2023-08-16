const simpleGit = require('simple-git');
const git = simpleGit();

let lastCommitHash = '';

async function checkForNewCommits() {
  // Fetch the latest changes from the remote repository
  await git.fetch();

  // Get the latest commit hash on the branch you want to monitor
  const log = await git.log({ maxCount: 1 });
  const latestCommitHash = log.latest.hash;

  // Check if there's a new commit
  if (lastCommitHash && latestCommitHash !== lastCommitHash) {
    console.log('New commit detected:', latestCommitHash);
    // You can add additional actions here, such as sending a notification
  }

  lastCommitHash = latestCommitHash;
}

// Run the checkForNewCommits function every minute
setInterval(checkForNewCommits, 60 * 1000);
