namespace WhereIsMyMoneyRepository.WalletRepository
{
    public interface IWalletRepository
    {
        void Create(WalletDto wallet);

        void Delete(string id);

        void Update(WalletDto wallet);

        WalletDto GetWallet(string id);
    }
}
