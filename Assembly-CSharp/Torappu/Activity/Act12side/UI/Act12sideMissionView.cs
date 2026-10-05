using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB9 RID: 31417
	[Token(Token = "0x2007AB9")]
	public class Act12sideMissionView : DataBinder<Act12sideMissionProperty>
	{
		// Token: 0x0602C014 RID: 180244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C014")]
		[Address(RVA = "0x27FE610", Offset = "0x27FD210", VA = "0x1827FE610")]
		public void Init(string actId)
		{
		}

		// Token: 0x0602C015 RID: 180245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C015")]
		[Address(RVA = "0x27FE690", Offset = "0x27FD290", VA = "0x1827FE690", Slot = "7")]
		public override void OnValueChanged(Act12sideMissionProperty property)
		{
		}

		// Token: 0x0602C016 RID: 180246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C016")]
		[Address(RVA = "0x27FEA90", Offset = "0x27FD690", VA = "0x1827FEA90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C017 RID: 180247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C017")]
		[Address(RVA = "0x27FEB50", Offset = "0x27FD750", VA = "0x1827FEB50")]
		private void _OnFilterSelected(Act12SideData.ActZoneClass zoneClass)
		{
		}

		// Token: 0x0602C018 RID: 180248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C018")]
		[Address(RVA = "0x27FEC10", Offset = "0x27FD810", VA = "0x1827FEC10")]
		private void _TraverseFilterList(Action<Act12sideMissionFilterItemView> action)
		{
		}

		// Token: 0x0602C019 RID: 180249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C019")]
		[Address(RVA = "0x27FED40", Offset = "0x27FD940", VA = "0x1827FED40")]
		public Act12sideMissionView()
		{
		}

		// Token: 0x0403FC2A RID: 261162
		[Token(Token = "0x403FC2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act12sideMissionListAdapter _listAdapter;

		// Token: 0x0403FC2B RID: 261163
		[Token(Token = "0x403FC2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act12sideMissionFilterItemView[] _filterItems;

		// Token: 0x0403FC2C RID: 261164
		[Token(Token = "0x403FC2C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCompletion;

		// Token: 0x0403FC2D RID: 261165
		[Token(Token = "0x403FC2D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMilestonePoint;

		// Token: 0x0403FC2E RID: 261166
		[Token(Token = "0x403FC2E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403FC2F RID: 261167
		[Token(Token = "0x403FC2F")]
		[FieldOffset(Offset = "0x48")]
		private Act12sideMissionProperty m_property;

		// Token: 0x0403FC30 RID: 261168
		[Token(Token = "0x403FC30")]
		[FieldOffset(Offset = "0x50")]
		private Act12sideMissionViewModel m_missionViewModel;

		// Token: 0x0403FC31 RID: 261169
		[Token(Token = "0x403FC31")]
		[FieldOffset(Offset = "0x58")]
		private string m_actId;

		// Token: 0x0403FC32 RID: 261170
		[Token(Token = "0x403FC32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403FC33 RID: 261171
		[Token(Token = "0x403FC33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403FC34 RID: 261172
		[Token(Token = "0x403FC34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FC35 RID: 261173
		[Token(Token = "0x403FC35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnFilterSelected;

		// Token: 0x0403FC36 RID: 261174
		[Token(Token = "0x403FC36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TraverseFilterList;

		// Token: 0x0403FC37 RID: 261175
		[Token(Token = "0x403FC37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
