using Cagem_CQRS.Cqrs.Results;
using Cagem_CQRS.Dal;

namespace Cagem_CQRS.Cqrs.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handler()
        {
            var values = _context.Products.Select(p => new GetProductQueryResult
            {

                Brand = p.Brand,
                Category = p.Category,
                Name = p.Name,
                Price = p.Price,
                ProductId = p.ProductId,
                Stock = p.Stock
            }).ToList();
            return values;
        }

    }
}

