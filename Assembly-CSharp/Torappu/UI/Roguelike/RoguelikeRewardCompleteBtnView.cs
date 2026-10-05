using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053D2 RID: 21458
	[Token(Token = "0x20053D2")]
	public class RoguelikeRewardCompleteBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x0601F94A RID: 129354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F94B RID: 129355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049F5")]
		public Action onBtnClicked
		{
			[Token(Token = "0x601F94A")]
			[Address(RVA = "0x1939670", Offset = "0x1938270", VA = "0x181939670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F94B")]
			[Address(RVA = "0x19396D0", Offset = "0x19382D0", VA = "0x1819396D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F94C RID: 129356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F94C")]
		[Address(RVA = "0x1939500", Offset = "0x1938100", VA = "0x181939500")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0601F94D RID: 129357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F94D")]
		[Address(RVA = "0x1939610", Offset = "0x1938210", VA = "0x181939610")]
		public RoguelikeRewardCompleteBtnView()
		{
		}

		// Token: 0x0402A852 RID: 174162
		[Token(Token = "0x402A852")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnClicked;

		// Token: 0x0402A853 RID: 174163
		[Token(Token = "0x402A853")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnClicked;

		// Token: 0x0402A854 RID: 174164
		[Token(Token = "0x402A854")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402A855 RID: 174165
		[Token(Token = "0x402A855")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
