using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200346E RID: 13422
	[Token(Token = "0x200346E")]
	[CreateAssetMenu(menuName = "Torappu/Activity/Outlinks")]
	[Serializable]
	public class ActivityOutlinks : ScriptableObject
	{
		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x060156AA RID: 87722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700329A")]
		public CommonTopMenu commonTopMenu
		{
			[Token(Token = "0x60156AA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x060156AB RID: 87723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700329B")]
		public UIItemCard uiItemCard
		{
			[Token(Token = "0x60156AB")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x060156AC RID: 87724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700329C")]
		public GameObject hotSpot
		{
			[Token(Token = "0x60156AC")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060156AD RID: 87725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156AD")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public ActivityOutlinks()
		{
		}

		// Token: 0x04019A46 RID: 105030
		[Token(Token = "0x4019A46")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CommonTopMenu _commonTopMenu;

		// Token: 0x04019A47 RID: 105031
		[Token(Token = "0x4019A47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIItemCard _uiItemCard;

		// Token: 0x04019A48 RID: 105032
		[Token(Token = "0x4019A48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hotSpot;
	}
}
