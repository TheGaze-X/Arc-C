using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DC2 RID: 19906
	[Token(Token = "0x2004DC2")]
	public class NameCardV2ShareAssistRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DC33 RID: 121907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC33")]
		[Address(RVA = "0x175DBB0", Offset = "0x175C7B0", VA = "0x18175DBB0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC34 RID: 121908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC34")]
		[Address(RVA = "0x175DE90", Offset = "0x175CA90", VA = "0x18175DE90")]
		public NameCardV2ShareAssistRemakeLayoutElement()
		{
		}

		// Token: 0x0402761B RID: 161307
		[Token(Token = "0x402761B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x0402761C RID: 161308
		[Token(Token = "0x402761C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _assistIcon;

		// Token: 0x0402761D RID: 161309
		[Token(Token = "0x402761D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _constTextAssistCN;

		// Token: 0x0402761E RID: 161310
		[Token(Token = "0x402761E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _constTextAssistEN;

		// Token: 0x0402761F RID: 161311
		[Token(Token = "0x402761F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _assistCharContent;

		// Token: 0x04027620 RID: 161312
		[Token(Token = "0x4027620")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04027621 RID: 161313
		[Token(Token = "0x4027621")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027622 RID: 161314
		[Token(Token = "0x4027622")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
