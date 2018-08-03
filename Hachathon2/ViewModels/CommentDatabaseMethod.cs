using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hachathon2
{
    public class CommentDatabaseMethod
    {

        readonly SQLiteAsyncConnection CommentsDatabase;
        public CommentDatabaseMethod(string dbPath)
        {
            CommentsDatabase = new SQLiteAsyncConnection(dbPath);
            CommentsDatabase.CreateTableAsync<CommentsDatabase>().Wait();

        }
        public Task<List<CommentsDatabase>> GetCommentAsync()
        {
            return CommentsDatabase.Table<CommentsDatabase>().ToListAsync();
        }
        public Task<CommentsDatabase> GetCommentAsync(int id)
        {
            return CommentsDatabase.Table<CommentsDatabase>().Where(i => i.CommentID == id).FirstOrDefaultAsync();
        }
        public Task<int> SavecampaignAsync(CommentsDatabase comment)
        {
            if (comment.CommentID != 0)
            {
                return CommentsDatabase.UpdateAsync(comment);
            }
            else
            {
                return CommentsDatabase.InsertAsync(comment);
            }
        }
        public Task<int> DeletecampaignAsync(CommentsDatabase comment)
        {
            return CommentsDatabase.DeleteAsync(comment);
        }
        public Task<List<CommentsDatabase>> Comments(int CampaignID)
        {
            return CommentsDatabase.QueryAsync<CommentsDatabase>("SELECT * FROM [CommentsDatabase] WHERE CampaignID_C = CampaignID");
        }

    }
}
