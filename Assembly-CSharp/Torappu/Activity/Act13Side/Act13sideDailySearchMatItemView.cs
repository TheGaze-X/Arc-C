using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A33 RID: 31283
	[Token(Token = "0x2007A33")]
	public class Act13sideDailySearchMatItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066C9 RID: 26313
		// (get) Token: 0x0602BD57 RID: 179543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD58 RID: 179544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066C9")]
		public Action<ItemBundle> onItemClick
		{
			[Token(Token = "0x602BD57")]
			[Address(RVA = "0x27B5EC0", Offset = "0x27B4AC0", VA = "0x1827B5EC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD58")]
			[Address(RVA = "0x27B5F20", Offset = "0x27B4B20", VA = "0x1827B5F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BD59 RID: 179545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD59")]
		[Address(RVA = "0x27B5AA0", Offset = "0x27B46A0", VA = "0x1827B5AA0")]
		public void Render(Act13sideDailySearchViewModel searchModel, ItemBundle matData)
		{
		}

		// Token: 0x0602BD5A RID: 179546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD5A")]
		[Address(RVA = "0x27B5CF0", Offset = "0x27B48F0", VA = "0x1827B5CF0")]
		private void _UpdateIconIfNeed(ItemBundle matData)
		{
		}

		// Token: 0x0602BD5B RID: 179547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD5B")]
		[Address(RVA = "0x27B5990", Offset = "0x27B4590", VA = "0x1827B5990")]
		public void OnItemClick()
		{
		}

		// Token: 0x0602BD5C RID: 179548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD5C")]
		[Address(RVA = "0x27B5E60", Offset = "0x27B4A60", VA = "0x1827B5E60")]
		public Act13sideDailySearchMatItemView()
		{
		}

		// Token: 0x0403F722 RID: 259874
		[Token(Token = "0x403F722")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectedBgGo;

		// Token: 0x0403F723 RID: 259875
		[Token(Token = "0x403F723")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalBgGo;

		// Token: 0x0403F724 RID: 259876
		[Token(Token = "0x403F724")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x0403F726 RID: 259878
		[Token(Token = "0x403F726")]
		[FieldOffset(Offset = "0x38")]
		private string m_cacheItemId;

		// Token: 0x0403F727 RID: 259879
		[Token(Token = "0x403F727")]
		[FieldOffset(Offset = "0x40")]
		private ItemBundle m_matData;

		// Token: 0x0403F728 RID: 259880
		[Token(Token = "0x403F728")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403F729 RID: 259881
		[Token(Token = "0x403F729")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403F72A RID: 259882
		[Token(Token = "0x403F72A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F72B RID: 259883
		[Token(Token = "0x403F72B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateIconIfNeed;

		// Token: 0x0403F72C RID: 259884
		[Token(Token = "0x403F72C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403F72D RID: 259885
		[Token(Token = "0x403F72D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
