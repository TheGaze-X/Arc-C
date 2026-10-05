using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073A3 RID: 29603
	[Token(Token = "0x20073A3")]
	public class Act42D0RewardAreaView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D82 RID: 171394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D82")]
		[Address(RVA = "0x25733B0", Offset = "0x2571FB0", VA = "0x1825733B0")]
		public void Render(string selectedAreaId, ListDict<string, Act42D0RewardAreaViewModel> areas)
		{
		}

		// Token: 0x06029D83 RID: 171395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D83")]
		[Address(RVA = "0x25735D0", Offset = "0x25721D0", VA = "0x1825735D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D84 RID: 171396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D84")]
		[Address(RVA = "0x2573730", Offset = "0x2572330", VA = "0x182573730")]
		public Act42D0RewardAreaView()
		{
		}

		// Token: 0x0403BF59 RID: 245593
		[Token(Token = "0x403BF59")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BF5A RID: 245594
		[Token(Token = "0x403BF5A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0403BF5B RID: 245595
		[Token(Token = "0x403BF5B")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, Act42D0RewardAreaViewModel> m_cachedViewModels;

		// Token: 0x0403BF5C RID: 245596
		[Token(Token = "0x403BF5C")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedAreaId;

		// Token: 0x0403BF5D RID: 245597
		[Token(Token = "0x403BF5D")]
		[FieldOffset(Offset = "0x38")]
		private Act42D0RewardAreaView.Adapter m_adapter;

		// Token: 0x0403BF5E RID: 245598
		[Token(Token = "0x403BF5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF5F RID: 245599
		[Token(Token = "0x403BF5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BF60 RID: 245600
		[Token(Token = "0x403BF60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073A4 RID: 29604
		[Token(Token = "0x20073A4")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029D85 RID: 171397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029D85")]
			[Address(RVA = "0x2580090", Offset = "0x257EC90", VA = "0x182580090")]
			public Adapter(Act42D0RewardAreaView closure)
			{
			}

			// Token: 0x170062CF RID: 25295
			// (get) Token: 0x06029D86 RID: 171398 RVA: 0x000D6C38 File Offset: 0x000D4E38
			[Token(Token = "0x170062CF")]
			public override int count
			{
				[Token(Token = "0x6029D86")]
				[Address(RVA = "0x2580110", Offset = "0x257ED10", VA = "0x182580110", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029D87 RID: 171399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029D87")]
			[Address(RVA = "0x257FA80", Offset = "0x257E680", VA = "0x18257FA80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BF61 RID: 245601
			[Token(Token = "0x403BF61")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0RewardAreaView m_closure;

			// Token: 0x0403BF62 RID: 245602
			[Token(Token = "0x403BF62")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BF63 RID: 245603
			[Token(Token = "0x403BF63")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BF64 RID: 245604
			[Token(Token = "0x403BF64")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
