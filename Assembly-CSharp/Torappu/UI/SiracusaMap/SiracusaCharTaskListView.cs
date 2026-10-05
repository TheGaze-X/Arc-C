using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F13 RID: 16147
	[Token(Token = "0x2003F13")]
	public abstract class SiracusaCharTaskListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x06019122 RID: 102690 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019123 RID: 102691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BFD")]
		public Action<string, string> onTaskClick
		{
			[Token(Token = "0x6019122")]
			[Address(RVA = "0x11B25D0", Offset = "0x11B11D0", VA = "0x1811B25D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019123")]
			[Address(RVA = "0x11B2630", Offset = "0x11B1230", VA = "0x1811B2630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019124 RID: 102692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019124")]
		[Address(RVA = "0x11B2280", Offset = "0x11B0E80", VA = "0x1811B2280", Slot = "4")]
		public virtual void Render(SiracusaCharTaskRingModel taskRingModel)
		{
		}

		// Token: 0x06019125 RID: 102693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019125")]
		[Address(RVA = "0x11B2440", Offset = "0x11B1040", VA = "0x1811B2440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019126 RID: 102694 RVA: 0x0009CEA0 File Offset: 0x0009B0A0
		[Token(Token = "0x6019126")]
		[Address(RVA = "0x11B20B0", Offset = "0x11B0CB0", VA = "0x1811B20B0")]
		public float GetListHeight()
		{
			return 0f;
		}

		// Token: 0x06019127 RID: 102695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019127")]
		[Address(RVA = "0x11B2560", Offset = "0x11B1160", VA = "0x1811B2560")]
		protected SiracusaCharTaskListView()
		{
		}

		// Token: 0x0401F03C RID: 127036
		[Token(Token = "0x401F03C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _taskList;

		// Token: 0x0401F03D RID: 127037
		[Token(Token = "0x401F03D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VerticalLayoutGroup _taskListLayoutGroup;

		// Token: 0x0401F03E RID: 127038
		[Token(Token = "0x401F03E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SiracusaCharTaskItemView _taskItemView;

		// Token: 0x0401F03F RID: 127039
		[Token(Token = "0x401F03F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _additionalOffset;

		// Token: 0x0401F040 RID: 127040
		[Token(Token = "0x401F040")]
		[FieldOffset(Offset = "0x34")]
		private bool m_hasInited;

		// Token: 0x0401F041 RID: 127041
		[Token(Token = "0x401F041")]
		[FieldOffset(Offset = "0x38")]
		private SiracusaCharTaskListView.Adapter m_adapter;

		// Token: 0x0401F042 RID: 127042
		[Token(Token = "0x401F042")]
		[FieldOffset(Offset = "0x40")]
		private SiracusaCharTaskRingModel m_taskRingModel;

		// Token: 0x0401F044 RID: 127044
		[Token(Token = "0x401F044")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTaskClick;

		// Token: 0x0401F045 RID: 127045
		[Token(Token = "0x401F045")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTaskClick;

		// Token: 0x0401F046 RID: 127046
		[Token(Token = "0x401F046")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F047 RID: 127047
		[Token(Token = "0x401F047")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F048 RID: 127048
		[Token(Token = "0x401F048")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetListHeight;

		// Token: 0x0401F049 RID: 127049
		[Token(Token = "0x401F049")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F14 RID: 16148
		[Token(Token = "0x2003F14")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06019128 RID: 102696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019128")]
			[Address(RVA = "0x11AC970", Offset = "0x11AB570", VA = "0x1811AC970")]
			public Adapter(SiracusaCharTaskListView closure)
			{
			}

			// Token: 0x17003BFE RID: 15358
			// (get) Token: 0x06019129 RID: 102697 RVA: 0x0009CEB8 File Offset: 0x0009B0B8
			[Token(Token = "0x17003BFE")]
			public override int count
			{
				[Token(Token = "0x6019129")]
				[Address(RVA = "0x11AC9F0", Offset = "0x11AB5F0", VA = "0x1811AC9F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601912A RID: 102698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601912A")]
			[Address(RVA = "0x11AC220", Offset = "0x11AAE20", VA = "0x1811AC220", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401F04A RID: 127050
			[Token(Token = "0x401F04A")]
			[FieldOffset(Offset = "0x20")]
			private SiracusaCharTaskListView m_closure;

			// Token: 0x0401F04B RID: 127051
			[Token(Token = "0x401F04B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F04C RID: 127052
			[Token(Token = "0x401F04C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F04D RID: 127053
			[Token(Token = "0x401F04D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
