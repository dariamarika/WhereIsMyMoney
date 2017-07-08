using WhereIsMyMoneyRepository.WalletRepository;

namespace WhereIsMyMoneyService.WalletService
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public void Create(WalletDto wallet)
        {
            _walletRepository.Create(wallet);
        }

        public void Delete(string id)
        {
            _walletRepository.Delete(id);
        }

        public void Update(WalletDto wallet)
        {
            _walletRepository.Update(wallet);
        }

        public WalletDto GetWallet(string id)
        {
            return _walletRepository.GetWallet(id);
        }
    }
}
