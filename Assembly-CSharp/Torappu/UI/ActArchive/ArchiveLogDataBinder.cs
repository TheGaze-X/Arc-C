using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B9F RID: 27551
	[Token(Token = "0x2006B9F")]
	public class ArchiveLogDataBinder : DataBinder<LogProperty>
	{
		// Token: 0x17005CED RID: 23789
		// (get) Token: 0x06027596 RID: 161174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027597 RID: 161175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CED")]
		public ActArchiveController controller
		{
			[Token(Token = "0x6027596")]
			[Address(RVA = "0x2285E00", Offset = "0x2284A00", VA = "0x182285E00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027597")]
			[Address(RVA = "0x2285E60", Offset = "0x2284A60", VA = "0x182285E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027598 RID: 161176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027598")]
		[Address(RVA = "0x22857E0", Offset = "0x22843E0", VA = "0x1822857E0", Slot = "7")]
		public override void OnValueChanged(LogProperty property)
		{
		}

		// Token: 0x06027599 RID: 161177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027599")]
		[Address(RVA = "0x2285AB0", Offset = "0x22846B0", VA = "0x182285AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602759A RID: 161178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602759A")]
		[Address(RVA = "0x2285D30", Offset = "0x2284930", VA = "0x182285D30")]
		public ArchiveLogDataBinder()
		{
		}

		// Token: 0x04037BED RID: 228333
		[Token(Token = "0x4037BED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ArchiveLogDataBinder.LogIconConfig> _itemIconConfig;

		// Token: 0x04037BEE RID: 228334
		[Token(Token = "0x4037BEE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04037BEF RID: 228335
		[Token(Token = "0x4037BEF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _logItemContainer;

		// Token: 0x04037BF0 RID: 228336
		[Token(Token = "0x4037BF0")]
		[FieldOffset(Offset = "0x38")]
		private ArchiveLogModel m_cachedModel;

		// Token: 0x04037BF1 RID: 228337
		[Token(Token = "0x4037BF1")]
		[FieldOffset(Offset = "0x40")]
		private ArchiveLogDataBinder.ItemListAdapter m_itemListAdapter;

		// Token: 0x04037BF2 RID: 228338
		[Token(Token = "0x4037BF2")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveLogDataBinder.LogItemAdapter m_logItemAdapter;

		// Token: 0x04037BF3 RID: 228339
		[Token(Token = "0x4037BF3")]
		[FieldOffset(Offset = "0x50")]
		private ArchiveLogDataBinder.LogTitleParam m_cachedTitleParam;

		// Token: 0x04037BF4 RID: 228340
		[Token(Token = "0x4037BF4")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<Act17sideData.ChapterIconType, Sprite> m_iconMap;

		// Token: 0x04037BF5 RID: 228341
		[Token(Token = "0x4037BF5")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04037BF7 RID: 228343
		[Token(Token = "0x4037BF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037BF8 RID: 228344
		[Token(Token = "0x4037BF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037BF9 RID: 228345
		[Token(Token = "0x4037BF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037BFA RID: 228346
		[Token(Token = "0x4037BFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037BFB RID: 228347
		[Token(Token = "0x4037BFB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BA0 RID: 27552
		[Token(Token = "0x2006BA0")]
		public class ItemListAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005CEE RID: 23790
			// (get) Token: 0x0602759B RID: 161179 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602759C RID: 161180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005CEE")]
			public ListDict<string, LogItemModel> dataSet
			{
				[Token(Token = "0x602759B")]
				[Address(RVA = "0x228BFA0", Offset = "0x228ABA0", VA = "0x18228BFA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602759C")]
				[Address(RVA = "0x228C000", Offset = "0x228AC00", VA = "0x18228C000")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005CEF RID: 23791
			// (get) Token: 0x0602759D RID: 161181 RVA: 0x000CE2B0 File Offset: 0x000CC4B0
			[Token(Token = "0x17005CEF")]
			public override int count
			{
				[Token(Token = "0x602759D")]
				[Address(RVA = "0x228BEE0", Offset = "0x228AAE0", VA = "0x18228BEE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602759E RID: 161182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602759E")]
			[Address(RVA = "0x228BE60", Offset = "0x228AA60", VA = "0x18228BE60")]
			public ItemListAdapter(ArchiveLogDataBinder closure)
			{
			}

			// Token: 0x0602759F RID: 161183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602759F")]
			[Address(RVA = "0x228BB40", Offset = "0x228A740", VA = "0x18228BB40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037BFC RID: 228348
			[Token(Token = "0x4037BFC")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveLogDataBinder m_closure;

			// Token: 0x04037BFE RID: 228350
			[Token(Token = "0x4037BFE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04037BFF RID: 228351
			[Token(Token = "0x4037BFF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04037C00 RID: 228352
			[Token(Token = "0x4037C00")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037C01 RID: 228353
			[Token(Token = "0x4037C01")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037C02 RID: 228354
			[Token(Token = "0x4037C02")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006BA1 RID: 27553
		[Token(Token = "0x2006BA1")]
		public class LogItemAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x060275A0 RID: 161184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60275A0")]
			[Address(RVA = "0x228DF20", Offset = "0x228CB20", VA = "0x18228DF20")]
			public LogItemAdapter(ArchiveLogDataBinder closure)
			{
			}

			// Token: 0x17005CF0 RID: 23792
			// (get) Token: 0x060275A1 RID: 161185 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060275A2 RID: 161186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005CF0")]
			public List<ActArchiveResData.LogArchiveResItemData> dataSet
			{
				[Token(Token = "0x60275A1")]
				[Address(RVA = "0x228E060", Offset = "0x228CC60", VA = "0x18228E060")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60275A2")]
				[Address(RVA = "0x228E0C0", Offset = "0x228CCC0", VA = "0x18228E0C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005CF1 RID: 23793
			// (get) Token: 0x060275A3 RID: 161187 RVA: 0x000CE2C8 File Offset: 0x000CC4C8
			[Token(Token = "0x17005CF1")]
			public override int count
			{
				[Token(Token = "0x60275A3")]
				[Address(RVA = "0x228DFA0", Offset = "0x228CBA0", VA = "0x18228DFA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060275A4 RID: 161188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60275A4")]
			[Address(RVA = "0x228DBD0", Offset = "0x228C7D0", VA = "0x18228DBD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037C03 RID: 228355
			[Token(Token = "0x4037C03")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveLogDataBinder m_closure;

			// Token: 0x04037C05 RID: 228357
			[Token(Token = "0x4037C05")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037C06 RID: 228358
			[Token(Token = "0x4037C06")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04037C07 RID: 228359
			[Token(Token = "0x4037C07")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04037C08 RID: 228360
			[Token(Token = "0x4037C08")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037C09 RID: 228361
			[Token(Token = "0x4037C09")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006BA2 RID: 27554
		[Token(Token = "0x2006BA2")]
		[Serializable]
		public struct LogIconConfig
		{
			// Token: 0x04037C0A RID: 228362
			[Token(Token = "0x4037C0A")]
			[FieldOffset(Offset = "0x0")]
			public Act17sideData.ChapterIconType iconType;

			// Token: 0x04037C0B RID: 228363
			[Token(Token = "0x4037C0B")]
			[FieldOffset(Offset = "0x8")]
			public Sprite iconImage;
		}

		// Token: 0x02006BA3 RID: 27555
		[Token(Token = "0x2006BA3")]
		public struct LogTitleParam
		{
			// Token: 0x04037C0C RID: 228364
			[Token(Token = "0x4037C0C")]
			[FieldOffset(Offset = "0x0")]
			public string logTitle;

			// Token: 0x04037C0D RID: 228365
			[Token(Token = "0x4037C0D")]
			[FieldOffset(Offset = "0x8")]
			public string logDisplayId;
		}
	}
}
