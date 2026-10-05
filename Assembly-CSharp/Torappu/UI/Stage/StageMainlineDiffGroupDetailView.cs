using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006900 RID: 26880
	[Token(Token = "0x2006900")]
	public class StageMainlineDiffGroupDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602680F RID: 157711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602680F")]
		[Address(RVA = "0x21A0A60", Offset = "0x219F660", VA = "0x1821A0A60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026810 RID: 157712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026810")]
		[Address(RVA = "0x21A0710", Offset = "0x219F310", VA = "0x1821A0710")]
		public void Render(ZoneViewModel viewModel)
		{
		}

		// Token: 0x06026811 RID: 157713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026811")]
		[Address(RVA = "0x21A0C20", Offset = "0x219F820", VA = "0x1821A0C20")]
		public StageMainlineDiffGroupDetailView()
		{
		}

		// Token: 0x04036432 RID: 222258
		[Token(Token = "0x4036432")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04036433 RID: 222259
		[Token(Token = "0x4036433")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _splitContent;

		// Token: 0x04036434 RID: 222260
		[Token(Token = "0x4036434")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unlockedPart;

		// Token: 0x04036435 RID: 222261
		[Token(Token = "0x4036435")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x04036436 RID: 222262
		[Token(Token = "0x4036436")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<StageDiffGroup> diffGroupEvent;

		// Token: 0x04036437 RID: 222263
		[Token(Token = "0x4036437")]
		[FieldOffset(Offset = "0x40")]
		private StageMainlineDiffGroupDetailView.Adapter m_adatper;

		// Token: 0x04036438 RID: 222264
		[Token(Token = "0x4036438")]
		[FieldOffset(Offset = "0x48")]
		private StageMainlineDiffGroupDetailView.SplitLineAdapter m_splitAdapter;

		// Token: 0x04036439 RID: 222265
		[Token(Token = "0x4036439")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0403643A RID: 222266
		[Token(Token = "0x403643A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403643B RID: 222267
		[Token(Token = "0x403643B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403643C RID: 222268
		[Token(Token = "0x403643C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006901 RID: 26881
		[Token(Token = "0x2006901")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005AE9 RID: 23273
			// (get) Token: 0x06026812 RID: 157714 RVA: 0x000CB5C8 File Offset: 0x000C97C8
			[Token(Token = "0x17005AE9")]
			public override int count
			{
				[Token(Token = "0x6026812")]
				[Address(RVA = "0x2190FF0", Offset = "0x218FBF0", VA = "0x182190FF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026813 RID: 157715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026813")]
			[Address(RVA = "0x2190CF0", Offset = "0x218F8F0", VA = "0x182190CF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026814 RID: 157716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026814")]
			[Address(RVA = "0x2190EB0", Offset = "0x218FAB0", VA = "0x182190EB0")]
			public Adapter()
			{
			}

			// Token: 0x0403643D RID: 222269
			[Token(Token = "0x403643D")]
			[FieldOffset(Offset = "0x20")]
			public ZoneViewModel viewModel;

			// Token: 0x0403643E RID: 222270
			[Token(Token = "0x403643E")]
			[FieldOffset(Offset = "0x28")]
			public Action<StageDiffGroup> diffGroupEvent;

			// Token: 0x0403643F RID: 222271
			[Token(Token = "0x403643F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036440 RID: 222272
			[Token(Token = "0x4036440")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04036441 RID: 222273
			[Token(Token = "0x4036441")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006902 RID: 26882
		[Token(Token = "0x2006902")]
		private class SplitLineAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005AEA RID: 23274
			// (get) Token: 0x06026815 RID: 157717 RVA: 0x000CB5E0 File Offset: 0x000C97E0
			[Token(Token = "0x17005AEA")]
			public override int count
			{
				[Token(Token = "0x6026815")]
				[Address(RVA = "0x2195550", Offset = "0x2194150", VA = "0x182195550", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026816 RID: 157718 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026816")]
			[Address(RVA = "0x21953F0", Offset = "0x2193FF0", VA = "0x1821953F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026817 RID: 157719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026817")]
			[Address(RVA = "0x21954F0", Offset = "0x21940F0", VA = "0x1821954F0")]
			public SplitLineAdapter()
			{
			}

			// Token: 0x04036442 RID: 222274
			[Token(Token = "0x4036442")]
			[FieldOffset(Offset = "0x20")]
			public ZoneViewModel viewModel;

			// Token: 0x04036443 RID: 222275
			[Token(Token = "0x4036443")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036444 RID: 222276
			[Token(Token = "0x4036444")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04036445 RID: 222277
			[Token(Token = "0x4036445")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
