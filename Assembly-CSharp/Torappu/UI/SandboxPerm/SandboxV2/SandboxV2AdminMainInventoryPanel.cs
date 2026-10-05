using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040AC RID: 16556
	[Token(Token = "0x20040AC")]
	public class SandboxV2AdminMainInventoryPanel : SandboxV2AdminMainTabPanel
	{
		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x060199CA RID: 104906 RVA: 0x0009ECA0 File Offset: 0x0009CEA0
		[Token(Token = "0x17003D1C")]
		public override SandboxV2AdminMainPanelType panelType
		{
			[Token(Token = "0x60199CA")]
			[Address(RVA = "0x124C340", Offset = "0x124AF40", VA = "0x18124C340", Slot = "9")]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x060199CB RID: 104907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D1D")]
		public override string topTitle
		{
			[Token(Token = "0x60199CB")]
			[Address(RVA = "0x124C3A0", Offset = "0x124AFA0", VA = "0x18124C3A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060199CC RID: 104908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199CC")]
		[Address(RVA = "0x124BB20", Offset = "0x124A720", VA = "0x18124BB20", Slot = "8")]
		protected override void OnUpdate(SandboxV2AdminMainTabPanelUpdateCase updateCase)
		{
		}

		// Token: 0x060199CD RID: 104909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199CD")]
		[Address(RVA = "0x124BED0", Offset = "0x124AAD0", VA = "0x18124BED0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060199CE RID: 104910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60199CE")]
		[Address(RVA = "0x124BA70", Offset = "0x124A670", VA = "0x18124BA70", Slot = "12")]
		public override IEnumerable<KeyValuePair<Type, Action<IStateBean>>> GetToDataListener()
		{
			return null;
		}

		// Token: 0x060199CF RID: 104911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199CF")]
		[Address(RVA = "0x124C130", Offset = "0x124AD30", VA = "0x18124C130")]
		private void _OpenDetailState(int idx)
		{
		}

		// Token: 0x060199D0 RID: 104912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199D0")]
		[Address(RVA = "0x124C2E0", Offset = "0x124AEE0", VA = "0x18124C2E0")]
		public SandboxV2AdminMainInventoryPanel()
		{
		}

		// Token: 0x060199D2 RID: 104914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60199D2")]
		[Address(RVA = "0x124BEC0", Offset = "0x124AAC0", VA = "0x18124BEC0")]
		private IEnumerable<KeyValuePair<Type, Action<IStateBean>>> <>xLuaBaseProxy_GetToDataListener()
		{
			return null;
		}

		// Token: 0x0401FFEE RID: 131054
		[Token(Token = "0x401FFEE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2AdminMainInventoryLeftTabView _leftTabView;

		// Token: 0x0401FFEF RID: 131055
		[Token(Token = "0x401FFEF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2AdminMainInventoryEmptyView _emptyTabView;

		// Token: 0x0401FFF0 RID: 131056
		[Token(Token = "0x401FFF0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2AdminMainInventoryItemView _itemView;

		// Token: 0x0401FFF1 RID: 131057
		[Token(Token = "0x401FFF1")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2AdminMainInventoryPanelModelProperty m_prop;

		// Token: 0x0401FFF2 RID: 131058
		[Token(Token = "0x401FFF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0401FFF3 RID: 131059
		[Token(Token = "0x401FFF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topTitle;

		// Token: 0x0401FFF4 RID: 131060
		[Token(Token = "0x401FFF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0401FFF5 RID: 131061
		[Token(Token = "0x401FFF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FFF6 RID: 131062
		[Token(Token = "0x401FFF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetToDataListener;

		// Token: 0x0401FFF7 RID: 131063
		[Token(Token = "0x401FFF7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OpenDetailState;

		// Token: 0x0401FFF8 RID: 131064
		[Token(Token = "0x401FFF8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
