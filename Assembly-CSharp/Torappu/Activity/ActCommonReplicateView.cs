using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D92 RID: 28050
	[Token(Token = "0x2006D92")]
	public class ActCommonReplicateView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027F4B RID: 163659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F4B")]
		[Address(RVA = "0x2332A70", Offset = "0x2331670", VA = "0x182332A70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027F4C RID: 163660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F4C")]
		[Address(RVA = "0x2332860", Offset = "0x2331460", VA = "0x182332860")]
		public void Render(string groupId)
		{
		}

		// Token: 0x06027F4D RID: 163661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F4D")]
		[Address(RVA = "0x2332B80", Offset = "0x2331780", VA = "0x182332B80")]
		public ActCommonReplicateView()
		{
		}

		// Token: 0x04038A04 RID: 231940
		[Token(Token = "0x4038A04")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04038A05 RID: 231941
		[Token(Token = "0x4038A05")]
		[FieldOffset(Offset = "0x20")]
		private ActCommonReplicateView.Adapter m_adatper;

		// Token: 0x04038A06 RID: 231942
		[Token(Token = "0x4038A06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038A07 RID: 231943
		[Token(Token = "0x4038A07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038A08 RID: 231944
		[Token(Token = "0x4038A08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D93 RID: 28051
		[Token(Token = "0x2006D93")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005E73 RID: 24179
			// (get) Token: 0x06027F4E RID: 163662 RVA: 0x000D0290 File Offset: 0x000CE490
			[Token(Token = "0x17005E73")]
			public override int count
			{
				[Token(Token = "0x6027F4E")]
				[Address(RVA = "0x2340AF0", Offset = "0x233F6F0", VA = "0x182340AF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027F4F RID: 163663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027F4F")]
			[Address(RVA = "0x23408B0", Offset = "0x233F4B0", VA = "0x1823408B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06027F50 RID: 163664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027F50")]
			[Address(RVA = "0x2340A90", Offset = "0x233F690", VA = "0x182340A90")]
			public Adapter()
			{
			}

			// Token: 0x04038A09 RID: 231945
			[Token(Token = "0x4038A09")]
			[FieldOffset(Offset = "0x20")]
			public ReplicateTable data;

			// Token: 0x04038A0A RID: 231946
			[Token(Token = "0x4038A0A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038A0B RID: 231947
			[Token(Token = "0x4038A0B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04038A0C RID: 231948
			[Token(Token = "0x4038A0C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
