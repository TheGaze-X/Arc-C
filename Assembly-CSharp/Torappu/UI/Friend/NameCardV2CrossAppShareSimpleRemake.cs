using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DBE RID: 19902
	[Token(Token = "0x2004DBE")]
	public class NameCardV2CrossAppShareSimpleRemake : CrossAppShareRemakeModelApplier
	{
		// Token: 0x0601DC14 RID: 121876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC14")]
		[Address(RVA = "0x175A9B0", Offset = "0x17595B0", VA = "0x18175A9B0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC15 RID: 121877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC15")]
		[Address(RVA = "0x175AB40", Offset = "0x1759740", VA = "0x18175AB40")]
		public NameCardV2CrossAppShareSimpleRemake()
		{
		}

		// Token: 0x040275D3 RID: 161235
		[Token(Token = "0x40275D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareBackgroundContent;

		// Token: 0x040275D4 RID: 161236
		[Token(Token = "0x40275D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareIllustContent;

		// Token: 0x040275D5 RID: 161237
		[Token(Token = "0x40275D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareCollectContent;

		// Token: 0x040275D6 RID: 161238
		[Token(Token = "0x40275D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareAvatarSimpleContent;

		// Token: 0x040275D7 RID: 161239
		[Token(Token = "0x40275D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x040275D8 RID: 161240
		[Token(Token = "0x40275D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
