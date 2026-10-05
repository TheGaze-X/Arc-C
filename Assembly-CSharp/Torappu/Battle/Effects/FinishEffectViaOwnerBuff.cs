using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200322A RID: 12842
	[Token(Token = "0x200322A")]
	public class FinishEffectViaOwnerBuff : Effect.Behaviour, IHotfixable
	{
		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x060145DD RID: 83421 RVA: 0x000869B8 File Offset: 0x00084BB8
		[Token(Token = "0x17003038")]
		private bool pauseInsteadOfFinish
		{
			[Token(Token = "0x60145DD")]
			[Address(RVA = "0xC9C630", Offset = "0xC9B230", VA = "0x180C9C630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060145DE RID: 83422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145DE")]
		[Address(RVA = "0xC9C2A0", Offset = "0xC9AEA0", VA = "0x180C9C2A0")]
		private void Update()
		{
		}

		// Token: 0x060145DF RID: 83423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145DF")]
		[Address(RVA = "0xC9C1F0", Offset = "0xC9ADF0", VA = "0x180C9C1F0")]
		private void SetPause(bool pause)
		{
		}

		// Token: 0x060145E0 RID: 83424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E0")]
		[Address(RVA = "0xC9C5D0", Offset = "0xC9B1D0", VA = "0x180C9C5D0")]
		public FinishEffectViaOwnerBuff()
		{
		}

		// Token: 0x04018077 RID: 98423
		[Token(Token = "0x4018077")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffId;

		// Token: 0x04018078 RID: 98424
		[Token(Token = "0x4018078")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _pauseInsteadOfFinish;

		// Token: 0x04018079 RID: 98425
		[Token(Token = "0x4018079")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		[Inspect("pauseInsteadOfFinish")]
		private bool _enableIfBuffExistsAgain;

		// Token: 0x0401807A RID: 98426
		[Token(Token = "0x401807A")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _useBehaviourPause;

		// Token: 0x0401807B RID: 98427
		[Token(Token = "0x401807B")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _invertPause;

		// Token: 0x0401807C RID: 98428
		[Token(Token = "0x401807C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pauseInsteadOfFinish;

		// Token: 0x0401807D RID: 98429
		[Token(Token = "0x401807D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401807E RID: 98430
		[Token(Token = "0x401807E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPause;

		// Token: 0x0401807F RID: 98431
		[Token(Token = "0x401807F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
