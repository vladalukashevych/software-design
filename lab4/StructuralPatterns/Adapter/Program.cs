using Adapter.Library;

Logger logger = new Logger();
logger.Log("Log message");
logger.Error("Error message");
logger.Warn("Warning message");

FileWriter fileWriter = new FileWriter("log.txt");
Logger fileLogger = new FileLoggerAdapter(fileWriter);
fileLogger.Log("Log message");
fileLogger.Error("Error message");
fileLogger.Warn("Warning message");