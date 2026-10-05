using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DD4 RID: 19924
	[Token(Token = "0x2004DD4")]
	public class NameCardV2ShareEquipInfoItemRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DCAF RID: 122031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCAF")]
		[Address(RVA = "0x17648F0", Offset = "0x17634F0", VA = "0x1817648F0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DCB0 RID: 122032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCB0")]
		[Address(RVA = "0x1764B60", Offset = "0x1763760", VA = "0x181764B60")]
		public NameCardV2ShareEquipInfoItemRemakeLayoutElement()
		{
		}

		// Token: 0x0402771C RID: 161564
		[Token(Token = "0x402771C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _totalObject;

		// Token: 0x0402771D RID: 161565
		[Token(Token = "0x402771D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtCurCount;

		// Token: 0x0402771E RID: 161566
		[Token(Token = "0x402771E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtTotalCount;

		// Token: 0x0402771F RID: 161567
		[Token(Token = "0x402771F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x04027720 RID: 161568
		[Token(Token = "0x4027720")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04027721 RID: 161569
		[Token(Token = "0x4027721")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027722 RID: 161570
		[Token(Token = "0x4027722")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
