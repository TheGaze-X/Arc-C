using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Network
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	public class WebHttpInstruction : CustomYieldInstruction, IDisposable
	{
		// Token: 0x06000CFA RID: 3322 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		private WebHttpInstruction()
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x557C4A0", Offset = "0x557B0A0", VA = "0x18557C4A0")]
		public static WebHttpInstruction Create(WebHttpResult handler)
		{
			return null;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000157")]
		public WebHttpResponse result
		{
			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0000860C File Offset: 0x0000680C
		[Token(Token = "0x17000158")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x557C5D0", Offset = "0x557B1D0", VA = "0x18557C5D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x557C580", Offset = "0x557B180", VA = "0x18557C580", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
		private void _OnHttpResponse(WebHttpResponse response)
		{
		}

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x10")]
		private WebHttpResult m_handler;
	}
}
