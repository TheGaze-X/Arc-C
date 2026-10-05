using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B0 RID: 13232
	[Token(Token = "0x20033B0")]
	public class UIBattleSandboxItemNotification : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x060151DB RID: 86491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700321D")]
		public List<UIBattleSandboxNotificationItem> itemViews
		{
			[Token(Token = "0x60151DB")]
			[Address(RVA = "0xD91240", Offset = "0xD8FE40", VA = "0x180D91240")]
			get
			{
				return null;
			}
		}

		// Token: 0x060151DC RID: 86492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151DC")]
		[Address(RVA = "0xD90D50", Offset = "0xD8F950", VA = "0x180D90D50")]
		private void Update()
		{
		}

		// Token: 0x060151DD RID: 86493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151DD")]
		[Address(RVA = "0xD90DB0", Offset = "0xD8F9B0", VA = "0x180D90DB0")]
		private void _Roll()
		{
		}

		// Token: 0x060151DE RID: 86494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151DE")]
		[Address(RVA = "0xD90A70", Offset = "0xD8F670", VA = "0x180D90A70")]
		public void InsertItemView(string itemId, int count)
		{
		}

		// Token: 0x060151DF RID: 86495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151DF")]
		[Address(RVA = "0xD91170", Offset = "0xD8FD70", VA = "0x180D91170")]
		public UIBattleSandboxItemNotification()
		{
		}

		// Token: 0x04019295 RID: 103061
		[Token(Token = "0x4019295")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _contentList;

		// Token: 0x04019296 RID: 103062
		[Token(Token = "0x4019296")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _spacing;

		// Token: 0x04019297 RID: 103063
		[Token(Token = "0x4019297")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _viewPrefab;

		// Token: 0x04019298 RID: 103064
		[Token(Token = "0x4019298")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _speed;

		// Token: 0x04019299 RID: 103065
		[Token(Token = "0x4019299")]
		[FieldOffset(Offset = "0x38")]
		private List<UIBattleSandboxNotificationItem> m_itemViews;

		// Token: 0x0401929A RID: 103066
		[Token(Token = "0x401929A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemViews;

		// Token: 0x0401929B RID: 103067
		[Token(Token = "0x401929B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401929C RID: 103068
		[Token(Token = "0x401929C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Roll;

		// Token: 0x0401929D RID: 103069
		[Token(Token = "0x401929D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InsertItemView;

		// Token: 0x0401929E RID: 103070
		[Token(Token = "0x401929E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
