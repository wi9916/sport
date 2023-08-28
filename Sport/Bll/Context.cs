using Microsoft.AspNetCore.Http.HttpResults;
using Sport.Models;

namespace Sport.Bll
{
    public class Context
    {
        public async Task<ArticleViewModel?> GetArticleById(int id)
        {

            return _articles.FirstOrDefault(ar => ar.Id == id);
        }

        public async Task<List<ArticleViewModel?>?> GetArticles(int page = 1, int amount = 10)
        {
            return _articles.Skip((page-1) * amount).ToList();
        }

        private readonly List<ArticleViewModel?> _articles = new List<ArticleViewModel?>
        {
            new ArticleViewModel
            {
                Id = 1,
                Title = "Lorem ipsum dolor sit amet",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Text = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Labore debitis beatae ad doloremque voluptate, blanditiis suscipit error quam fugit sapiente, aliquid quia libero incidunt recusandae enim voluptas nulla sequi similique? Temporibus ad est minima magni molestias obcaecati consequatur cumque exercitationem deleniti eos, animi facere recusandae, pariatur eveniet neque? Voluptatem, molestias.\r\n Lorem, ipsum dolor sit amet consectetur adipisicing elit. Beatae dignissimos dolorum ipsam corporis similique! Quis, esse minus? Ducimus tempore provident sunt officia? Velit temporibus harum voluptate, ipsum quisquam rerum doloremque consectetur quos incidunt deleniti dicta excepturi ratione, fugiat ad fuga in nam dolorum aut minus esse voluptatum suscipit et quae. Repellendus minus, ratione aperiam commodi voluptas iusto aliquam sapiente. Aut obcaecati, corporis praesentium porro nostrum excepturi animi repellendus incidunt non quis nisi assumenda voluptas possimus molestiae laboriosam iure sed architecto in perferendis magnam blanditiis voluptatum placeat labore odio? Unde id dolore aliquam, quas sit harum, saepe maiores facilis aliquid molestiae qui. Praesentium rerum, minima fugit laudantium quaerat voluptatem pariatur sequi saepe blanditiis nobis natus possimus quo, assumenda numquam sit, eaque accusamus incidunt exercitationem quis deleniti quisquam corrupti vel? Ut quisquam consequatur, doloribus voluptatibus iusto quaerat, sint non magnam reiciendis amet quos sapiente excepturi omnis laboriosam nobis, expedita delectus odio provident?\r\n",
                ImgUrl = "ent1.jpg",
                Author = "Written By John Doe",
                CreatedAt = DateTime.Now,
                Tags = new List<CategoryViewModel> { new CategoryViewModel {Name = "ENTERTAINMENT", Style = "category-ent" }, },
            },
           new ArticleViewModel
           {
                Id = 2,
                Title = "Lorem ipsum dolor sit amet",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Author = "Written By John Doe",
                CreatedAt = DateTime.Now,
                Tags = new List<CategoryViewModel> { new CategoryViewModel {Name = "SPORTS", Style = "category-sports" }, },
           },
           new ArticleViewModel
           {
                Id = 3,
                Title = "Lorem ipsum dolor sit amet",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                ImgUrl = "tech1.jpg",
                Author = "Written By John Doe",
                CreatedAt = DateTime.Now,
                Tags = new List<CategoryViewModel> { new CategoryViewModel {Name = "Technology", Style = "category-tech" }, },
           },
           new ArticleViewModel
           {
                Id = 4,
                Title = "Lorem ipsum dolor sit amet",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                ImgUrl = "sports1.jpg",
                Author = "Written By John Doe",
                CreatedAt = DateTime.Now,
                Tags = new List<CategoryViewModel> { new CategoryViewModel {Name = "SPORTS", Style = "category-sports" }, },
           },
           new ArticleViewModel
           {
                Id = 5,
                Title = "Lorem ipsum dolor sit amet",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                ImgUrl = "tech2.jpg",
                Author = "Written By John Doe",
                CreatedAt = DateTime.Now,
                Tags = new List<CategoryViewModel> { new CategoryViewModel {Name = "Technology", Style = "category-tech" }, },
           },
           new ArticleViewModel
           {
                Id = 6,
                Title = "Lorem ipsum dolor sit amet",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Author = "Written By John Doe",
                CreatedAt = DateTime.Now,
                Tags = new List<CategoryViewModel> { new CategoryViewModel {Name = "SPORTS", Style = "category-sports" }, },
           },
           new ArticleViewModel
           {
                Id = 7,
                Title = "Lorem ipsum dolor sit amet",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla quam eius ducimus optio veniam sit nihil beatae ea autem. Doloribus.",
                ImgUrl = "ent2.jpg",
                Author = "Written By John Doe",
                CreatedAt = DateTime.Now,
                Tags = new List<CategoryViewModel> { new CategoryViewModel {Name = "SPORTS", Style = "category-sports" }, },
           },
        };
    }
}
