namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        string path = Path.Combine (directoryName, "test-directory");
       Directory.CreateDirectory(path);
    }
}
