class PrefabFactory {
  constructor() {
    this.templates = {
      Pistol: { damage: 10, range: 50 },
      Rifle: { damage: 15, range: 100 },
      SMG: { damage: 8, range: 40 },
      LMG: { damage: 12, range: 80 },
      Shotgun: { damage: 20, range: 30 },
      Knife: { damage: 5, range: 5 },
      Machete: { damage: 7, range: 5 },
      Sword: { damage: 10, range: 5 },
      Chainsaw: { damage: 15, range: 5 },
      Grenade: { damage: 30, radius: 10 },
      Flamethrower: { damage: 10, range: 20 },
      FlareGun: { damage: 5, range: 50 },
      Claymore: { damage: 40, radius: 5 },
      ProjectileLauncher: { damage: 25, radius: 8 },
      SetExplosives: { damage: 50, radius: 10 },
      AssaultRifle: {},
      HuntingRifle: {},
      HybridRifle: {},
      Minigun: {},
      Nailgun: {},
      Revolver: {},
      SniperRifle: {},
      Speargun: {},
      Bow: {},
      Crossbow: {},
      ExplosiveArrows: {},
      Harpoons: {},
      FlashBangs: {},
      ThrownExplosives: {},
      Nailbomb: {},
      StopSignShield: {},
      ProjectileSpear: {},
      WeedTrimmerBlades: {},
      WeedTrimmerClean: {},
      BaseballBatWood: {},
      BaseballBatMetal: {},
      BaseballBatBarbed: {},
      Baton: {},
      ButcherAxe: {},
      WoodenCross: {},
      MedicalCrutch: {},
      Fireaxe: {},
      ClawHammer: {},
      Katana: {},
      GolfClub: {},
      HuntingKnife: {},
      MetalPipe: {},
      PipeWrench: {},
      Plank: {},
      Rebar: {},
      Spade: {},
      Woodaxe: {},
      Wrench: {}
    };
  }

  createTemplate(name, attributes) {
    this.templates[name] = Object.assign({}, this.templates[name], attributes);
    console.log(`Created template ${name} with attributes:`, attributes);
  }

  instantiateTemplate(name) {
    const template = this.templates[name];
    if (template) {
      console.log(`Instantiating template ${name}...`);
      return Object.assign({}, template);
    } else {
      console.log(`Template ${name} not found.`);
      return null;
    }
  }
}

module.exports = PrefabFactory;

// Example Usage
const factory = new PrefabFactory();
factory.createTemplate('Pistol', { ammoType: '9mm' });
factory.instantiateTemplate('Pistol');