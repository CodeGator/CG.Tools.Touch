
namespace CG.Tools.Touch;


/// <summary>
/// This class utility contains common file related code.
/// </summary>
internal static class Utility
{
    public static void TouchFile(
        string filePath,
        DateTime? lastWriteTime = null,
        DateTime? createTime = null
        )
    {
        if (File.Exists(filePath)) 
        {
            if (lastWriteTime is not null)
            {
                File.SetLastWriteTime(filePath, lastWriteTime.Value);
            }
            else
            {
                File.SetLastWriteTime(filePath, DateTime.Now);
            }

            if (createTime is not null)
            {
                File.SetCreationTime(filePath, createTime.Value);
            }
            else
            {
                File.SetCreationTime(filePath, DateTime.Now);
            }
        }
    }
}
