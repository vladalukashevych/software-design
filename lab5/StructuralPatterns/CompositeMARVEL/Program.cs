using CompositeMARVEL.Classes;

MarvelHero ironMan = new MarvelHero("IronMan", 3000);
ironMan.ActivateLog();

Artefact glasses = new Artefact("Glasses", 30, 100);
ironMan.AddArtefact(glasses);

ArtefactContainer glove = new ArtefactContainer("GloveOfPower");
glove.AddArtefact(new Artefact("SpaceStone", 10, 100));
glove.AddArtefact(new Artefact("RealityStone", 15, 150));
glove.AddArtefact(new Artefact("PowerStone", 10, 250));
glove.AddArtefact(new Artefact("MindStone", 15, 200));
glove.AddArtefact(new Artefact("TimeStone", 20, 300));

ironMan.AddArtefact(glove);

Console.WriteLine("\n");
ironMan.CountArtefacts();
ironMan.Strike();