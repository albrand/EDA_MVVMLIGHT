using EDA_MVVM.LIGHT.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDA_MVVM.LIGHT.Services
{
    public class FeedService
    {  
        public List<FeedModel> GetFeeds()
        {
            return new List<FeedModel>
            {
                new FeedModel { Id=1,
                    Titulo = "Aprendendo Xamarin"
                    , Autor = "Wesley Favarin"
                    , Texto = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt."},
                new FeedModel { Id=2,
                    Titulo = "Aprendendo MVVM"
                    , Autor = "Alexandre Brandizzi"
                    , Texto = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt."},
                new FeedModel { Id=3,
                    Titulo = "Xamarin MVVM.Light"
                    , Autor = "Anderson Oliveira"
                    , Texto = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt."},
                new FeedModel { Id=4,
                    Titulo = "É bem bacana..."
                    , Autor = "Dionísio"
                    , Texto = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt."},
                new FeedModel { Id=5,
                    Titulo = "Quero aprender também"
                    , Autor = "Kayo Chiaradia"
                    , Texto = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt."},
            };
        }
    }
}
