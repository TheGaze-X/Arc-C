using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DD1 RID: 19921
	[Token(Token = "0x2004DD1")]
	public class NameCardV2ShareEquipCollectionRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DCA2 RID: 122018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCA2")]
		[Address(RVA = "0x1763C20", Offset = "0x1762820", VA = "0x181763C20", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DCA3 RID: 122019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCA3")]
		[Address(RVA = "0x1763E20", Offset = "0x1762A20", VA = "0x181763E20")]
		public NameCardV2ShareEquipCollectionRemakeLayoutElement()
		{
		}

		// Token: 0x04027704 RID: 161540
		[Token(Token = "0x4027704")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x04027705 RID: 161541
		[Token(Token = "0x4027705")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgIcon;

		// Token: 0x04027706 RID: 161542
		[Token(Token = "0x4027706")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _infoContent;

		// Token: 0x04027707 RID: 161543
		[Token(Token = "0x4027707")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027708 RID: 161544
		[Token(Token = "0x4027708")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
