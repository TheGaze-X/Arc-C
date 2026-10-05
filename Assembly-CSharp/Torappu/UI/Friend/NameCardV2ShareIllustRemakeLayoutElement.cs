using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DD7 RID: 19927
	[Token(Token = "0x2004DD7")]
	public class NameCardV2ShareIllustRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DCBE RID: 122046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCBE")]
		[Address(RVA = "0x17650A0", Offset = "0x1763CA0", VA = "0x1817650A0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DCBF RID: 122047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCBF")]
		[Address(RVA = "0x17651F0", Offset = "0x1763DF0", VA = "0x1817651F0")]
		public NameCardV2ShareIllustRemakeLayoutElement()
		{
		}

		// Token: 0x0402773B RID: 161595
		[Token(Token = "0x402773B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrossAppShareRemakeDynAssetContent _crossAppShareIllustContent;

		// Token: 0x0402773C RID: 161596
		[Token(Token = "0x402773C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0402773D RID: 161597
		[Token(Token = "0x402773D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
