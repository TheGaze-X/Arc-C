using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B61 RID: 27489
	[Token(Token = "0x2006B61")]
	public class ArchiveDisasterListDataBinder : DataBinder<DisasterProperty>
	{
		// Token: 0x17005CD2 RID: 23762
		// (get) Token: 0x0602747B RID: 160891 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602747C RID: 160892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CD2")]
		public ArchiveDisasterController controller
		{
			[Token(Token = "0x602747B")]
			[Address(RVA = "0x2279FE0", Offset = "0x2278BE0", VA = "0x182279FE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602747C")]
			[Address(RVA = "0x227A040", Offset = "0x2278C40", VA = "0x18227A040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602747D RID: 160893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602747D")]
		[Address(RVA = "0x2279960", Offset = "0x2278560", VA = "0x182279960", Slot = "7")]
		public override void OnValueChanged(DisasterProperty property)
		{
		}

		// Token: 0x0602747E RID: 160894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602747E")]
		[Address(RVA = "0x2279E50", Offset = "0x2278A50", VA = "0x182279E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602747F RID: 160895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602747F")]
		[Address(RVA = "0x2279F70", Offset = "0x2278B70", VA = "0x182279F70")]
		public ArchiveDisasterListDataBinder()
		{
		}

		// Token: 0x040379C7 RID: 227783
		[Token(Token = "0x40379C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _levelContent;

		// Token: 0x040379C8 RID: 227784
		[Token(Token = "0x40379C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArchiveDisasterLeftPanelView _leftPanelView;

		// Token: 0x040379C9 RID: 227785
		[Token(Token = "0x40379C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveDisasterTypeItemAdapter _typeAdapter;

		// Token: 0x040379CA RID: 227786
		[Token(Token = "0x40379CA")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x040379CB RID: 227787
		[Token(Token = "0x40379CB")]
		[FieldOffset(Offset = "0x40")]
		private List<DisasterItemModel> m_cachedItemModels;

		// Token: 0x040379CC RID: 227788
		[Token(Token = "0x40379CC")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveDisasterListDataBinder.LevelItemAdapter m_levelAdapter;

		// Token: 0x040379CE RID: 227790
		[Token(Token = "0x40379CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040379CF RID: 227791
		[Token(Token = "0x40379CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040379D0 RID: 227792
		[Token(Token = "0x40379D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040379D1 RID: 227793
		[Token(Token = "0x40379D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040379D2 RID: 227794
		[Token(Token = "0x40379D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B62 RID: 27490
		[Token(Token = "0x2006B62")]
		private class LevelItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06027480 RID: 160896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027480")]
			[Address(RVA = "0x228CFF0", Offset = "0x228BBF0", VA = "0x18228CFF0")]
			public LevelItemAdapter(ArchiveDisasterListDataBinder closure)
			{
			}

			// Token: 0x17005CD3 RID: 23763
			// (get) Token: 0x06027481 RID: 160897 RVA: 0x000CDE90 File Offset: 0x000CC090
			[Token(Token = "0x17005CD3")]
			public override int count
			{
				[Token(Token = "0x6027481")]
				[Address(RVA = "0x228D070", Offset = "0x228BC70", VA = "0x18228D070", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027482 RID: 160898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027482")]
			[Address(RVA = "0x228CD10", Offset = "0x228B910", VA = "0x18228CD10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040379D3 RID: 227795
			[Token(Token = "0x40379D3")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveDisasterListDataBinder m_closure;

			// Token: 0x040379D4 RID: 227796
			[Token(Token = "0x40379D4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040379D5 RID: 227797
			[Token(Token = "0x40379D5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040379D6 RID: 227798
			[Token(Token = "0x40379D6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
