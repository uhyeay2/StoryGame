using StoryGame.ConsoleUI.Workflow;

var controller = new GameController(GameScreens.ScreenDictionary);

controller.Start(startingKey: GameScreens.StartingKey, endingKey: GameScreens.EndingKey);
