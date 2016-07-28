namespace MyDriving.Core.Repositories
{
    class RepositoryBase
    {
        public async void SaveAll()
        {
            await Data.AppDbContext.Instance.SaveChangesAsync();
        }
    }
}
