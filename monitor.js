const simpleGit = require('simple-git');
const git = simpleGit();

let lastCommitHash = '';

async function checkForNewCommits() {
  console.log('Monitoring for new commits...');

  try {
    await git.fetch();

    const log = await git.log({ maxCount: 1 });
    const latestCommitHash = log.latest.hash;

    if (lastCommitHash && latestCommitHash !== lastCommitHash) {
      console.log('New commit detected:', latestCommitHash);
      console.log('Pulling changes...');
      await git.pull();
      console.log('Pull complete.');
    }

    lastCommitHash = latestCommitHash;
  } catch (error) {
    console.error('An error occurred:', error);
  }
}

setInterval(checkForNewCommits, 60 * 1000);
setInterval(() => console.log('.'), 15 * 1000);