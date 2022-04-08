﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BitcoinNET.RPCClient
{
    //Courtesy mb300sd Bitcoin.NET
	public partial class CoinRPC
	{
	
  	    
        public string GetNewAddress(string Account = "")
        {
            return RpcCall<string>
                (new RPCRequest("getnewaddress", new Object[] { Account }));
        }

        public string GetNewLegacyAddress(string Account = "")
        {
            return RpcCall<string>
                (new RPCRequest("getnewaddress", new Object[] { Account , "legacy"}));
        }


        public IEnumerable<string> GetRawMemPool()
		{
			return RpcCall<IEnumerable<string>>
				(new RPCRequest("getrawmempool"));
		}

		public GetTransactionResponse GetTransaction(string TxID)
		{
			return RpcCall<GetTransactionResponse>
				(new RPCRequest("gettransaction", new Object[] { TxID }));
		}

        public GetRawDataTransactionResponse GetRawDataTransaction(string TxID, int Verbose = 0)
        {
            return RpcCall<GetRawDataTransactionResponse>
                (new RPCRequest("getrawtransaction", new Object[] { TxID, Verbose }));
        }

        public IDictionary<string, decimal> ListAccounts(int MinConf = 1)
		{
			return RpcCall<IDictionary<string, decimal>>
				(new RPCRequest("listaccounts", new Object[] { MinConf }));
		}

        public IDictionary<string, decimal> ListAccounts(int MinConf = 1, bool IncludeWatch = false)
        {
            return RpcCall<IDictionary<string, decimal>>
                (new RPCRequest("listaccounts", new Object[] { MinConf, IncludeWatch }));
        }
		
		public IEnumerable<ListReceivedByAddressResponse> ListReceivedByAddress(int MinConf = 1, bool IncludeEmpty = false)
		{
			return RpcCall<IEnumerable<ListReceivedByAddressResponse>>
				(new RPCRequest("listreceivedbyaddress", new Object[] { MinConf, IncludeEmpty }));
		}

       
        //public ListSinceBlockResponse ListSinceBlock(string BlockHash = null, int TargetConfirmations = 1)
        //{
        //    if (BlockHash == null)
        //    {
        //        return RpcCall<ListSinceBlockResponse>
        //            (new RPCRequest("listsinceblock"));
        //    }
        //    return RpcCall<ListSinceBlockResponse>
        //        (new RPCRequest("listsinceblock", new Object[] { BlockHash, TargetConfirmations }));
        //}

        public string ImportAddress(string Address, string Label, bool Rescan)
        {
            return RpcCall<string>
                (new RPCRequest("importaddress", new Object[] { Address, Label, Rescan }));
        }

        public string ImportPrivateKey(string PrivateKey, string Label, bool Rescan)
        {
            return RpcCall<string>
                (new RPCRequest("importprivkey", new Object[] { PrivateKey, Label, Rescan }));
        }

		
		public string SendMany( string FromAddress, IDictionary<string, decimal> ToBitcoinAddresses)
		{
			return RpcCall<string>
				(new RPCRequest("sendmany", new Object[] { FromAddress, ToBitcoinAddresses, 0 }));
		}

        public string SendData(string Data)
        {
            return RpcCall<string>
                (new RPCRequest("senddata", new Object[] { Data }));
        }

        public string SendRawTransaction(string Transaction)
        {
            return RpcCall<string>
                (new RPCRequest("sendrawtransaction", new Object[] { Transaction }));
        }

        public void SetTXFee(decimal fee)
        {
            RpcCall<Object>
                (new RPCRequest("settxfee",new Object[] {fee}));
        }

		
        public string SignMessage(string BitcoinAddress, string Message)
        {
            return RpcCall<string>
                (new RPCRequest("signmessage", new Object[] { BitcoinAddress, Message }));
        }


        public bool VerifyMessage(string BitcoinAddress, string Signature, string Message)
        {
            return RpcCall<bool>
                (new RPCRequest("verifymessage", new Object[] { BitcoinAddress, Signature, Message }));
        }

        public ValidateAddressResponse ValidateAddress(string Address)
        {
            return RpcCall<ValidateAddressResponse>
                (new RPCRequest("validateaddress", new Object[] { Address }));
        }

        public string DumpPrivateKey(string BitcoinAddress)
        {
            return RpcCall<string>
                (new RPCRequest("dumpprivkey", new Object[] { BitcoinAddress }));
        }

        public IEnumerable<ListTransactionsResponse> ListTransactions(string Account = "*", int Count = 10, int From = 0)
        {
            return RpcCall<IEnumerable<ListTransactionsResponse>>
                (new RPCRequest("listtransactions", new Object[] { Account, Count, From}));
        }

        public IEnumerable<ListTransactionsResponse> ListTransactions(string Account = "*", int Count = 10, int From = 0, bool IncludeWatch = false)
        {
            return RpcCall<IEnumerable<ListTransactionsResponse>>
                (new RPCRequest("listtransactions", new Object[] { Account, Count, From, IncludeWatch }));
        }


        public IEnumerable<string> GetAddressesByAccount(string Account)
        {
            return RpcCall<IEnumerable<string>>
                (new RPCRequest("getaddressesbyaccount", new Object[] { Account }));
        }
		
	}
}
