using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[AssetFileNameExtension("signal", new string[]
	{

	})]
	public class SignalAsset : ScriptableObject
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600028F RID: 655 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000290 RID: 656 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000003")]
		internal static event Action<SignalAsset> OnEnableCallback
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x58EBFA0", Offset = "0x58EABA0", VA = "0x1858EBFA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x58EC080", Offset = "0x58EAC80", VA = "0x1858EC080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x58EBF40", Offset = "0x58EAB40", VA = "0x1858EBF40")]
		private void OnEnable()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public SignalAsset()
		{
		}
	}
}
