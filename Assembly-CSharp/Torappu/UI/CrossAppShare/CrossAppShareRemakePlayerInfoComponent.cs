using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058FB RID: 22779
	[Token(Token = "0x20058FB")]
	public class CrossAppShareRemakePlayerInfoComponent : CrossAppShareRemakeBaseComponent<CrossAppSharePlayerInfoModel>, IHotfixable
	{
		// Token: 0x06021341 RID: 136001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021341")]
		[Address(RVA = "0x1B78670", Offset = "0x1B77270", VA = "0x181B78670", Slot = "5")]
		protected override void ApplyTypedModel(CrossAppSharePlayerInfoModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06021342 RID: 136002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021342")]
		[Address(RVA = "0x1B788C0", Offset = "0x1B774C0", VA = "0x181B788C0")]
		public CrossAppShareRemakePlayerInfoComponent()
		{
		}

		// Token: 0x0402D3A0 RID: 185248
		[Token(Token = "0x402D3A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0402D3A1 RID: 185249
		[Token(Token = "0x402D3A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402D3A2 RID: 185250
		[Token(Token = "0x402D3A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUid;

		// Token: 0x0402D3A3 RID: 185251
		[Token(Token = "0x402D3A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgAvatar;

		// Token: 0x0402D3A4 RID: 185252
		[Token(Token = "0x402D3A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x0402D3A5 RID: 185253
		[Token(Token = "0x402D3A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
