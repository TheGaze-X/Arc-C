using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004735 RID: 18229
	[Token(Token = "0x2004735")]
	public class RecruitBuildConfigRarityList : DataBinder<BuildConfigRarityProperty>
	{
		// Token: 0x0601BA10 RID: 113168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA10")]
		[Address(RVA = "0x14F6E90", Offset = "0x14F5A90", VA = "0x1814F6E90")]
		public void InitIfNot()
		{
		}

		// Token: 0x0601BA11 RID: 113169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA11")]
		[Address(RVA = "0x14F7110", Offset = "0x14F5D10", VA = "0x1814F7110", Slot = "7")]
		public override void OnValueChanged(BuildConfigRarityProperty property)
		{
		}

		// Token: 0x0601BA12 RID: 113170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA12")]
		[Address(RVA = "0x14F73C0", Offset = "0x14F5FC0", VA = "0x1814F73C0")]
		public RecruitBuildConfigRarityList()
		{
		}

		// Token: 0x04023D32 RID: 146738
		[Token(Token = "0x4023D32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitBuildConfigRarityItem _item;

		// Token: 0x04023D33 RID: 146739
		[Token(Token = "0x4023D33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023D34 RID: 146740
		[Token(Token = "0x4023D34")]
		[FieldOffset(Offset = "0x30")]
		private List<RecruitBuildConfigRarityItem> m_itemList;

		// Token: 0x04023D35 RID: 146741
		[Token(Token = "0x4023D35")]
		[FieldOffset(Offset = "0x38")]
		private bool m_initFlag;

		// Token: 0x04023D36 RID: 146742
		[Token(Token = "0x4023D36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04023D37 RID: 146743
		[Token(Token = "0x4023D37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023D38 RID: 146744
		[Token(Token = "0x4023D38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
