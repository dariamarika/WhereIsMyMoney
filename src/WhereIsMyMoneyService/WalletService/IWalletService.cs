using WhereIsMyMoneyRepository.WalletRepository;

namespace WhereIsMyMoneyService.WalletService
{
    public interface IWalletService
    {
        void Create(WalletDto wallet);

        void Delete(string id);

        void Update(WalletDto wallet);

        WalletDto GetWallet(string id);
    }
}
