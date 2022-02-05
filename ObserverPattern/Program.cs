// My Example - we are a band and we want to send a message to our subscribers when we play

var band = new Band("Hard Transylvania");
band.AddSubscriber(new Fan("Robert", "Kiosaki"));
band.AddSubscriber(new Fan("Jason", "Derulo"));
band.PlayMusic();
band.AddSubscriber(new Fan("Elisabeth", "II"));
band.StopPlay();