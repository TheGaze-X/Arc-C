using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	public interface ICertificatePolicy
	{
		// Token: 0x0600134B RID: 4939
		[Token(Token = "0x600134B")]
		bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
	}
}
