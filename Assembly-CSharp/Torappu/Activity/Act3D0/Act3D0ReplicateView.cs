using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200740E RID: 29710
	[Token(Token = "0x200740E")]
	public class Act3D0ReplicateView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F42 RID: 171842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F42")]
		[Address(RVA = "0x2590D30", Offset = "0x258F930", VA = "0x182590D30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029F43 RID: 171843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F43")]
		[Address(RVA = "0x2590B20", Offset = "0x258F720", VA = "0x182590B20")]
		public void Render(string groupId)
		{
		}

		// Token: 0x06029F44 RID: 171844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F44")]
		[Address(RVA = "0x2590E40", Offset = "0x258FA40", VA = "0x182590E40")]
		public Act3D0ReplicateView()
		{
		}

		// Token: 0x0403C234 RID: 246324
		[Token(Token = "0x403C234")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403C235 RID: 246325
		[Token(Token = "0x403C235")]
		[FieldOffset(Offset = "0x20")]
		private Act3D0ReplicateView.Adapter m_adatper;

		// Token: 0x0403C236 RID: 246326
		[Token(Token = "0x403C236")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C237 RID: 246327
		[Token(Token = "0x403C237")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C238 RID: 246328
		[Token(Token = "0x403C238")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200740F RID: 29711
		[Token(Token = "0x200740F")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700630F RID: 25359
			// (get) Token: 0x06029F45 RID: 171845 RVA: 0x000D70B8 File Offset: 0x000D52B8
			[Token(Token = "0x1700630F")]
			public override int count
			{
				[Token(Token = "0x6029F45")]
				[Address(RVA = "0x2592AD0", Offset = "0x25916D0", VA = "0x182592AD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029F46 RID: 171846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029F46")]
			[Address(RVA = "0x25924C0", Offset = "0x25910C0", VA = "0x1825924C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06029F47 RID: 171847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029F47")]
			[Address(RVA = "0x2592A10", Offset = "0x2591610", VA = "0x182592A10")]
			public Adapter()
			{
			}

			// Token: 0x0403C239 RID: 246329
			[Token(Token = "0x403C239")]
			[FieldOffset(Offset = "0x20")]
			public ReplicateTable data;

			// Token: 0x0403C23A RID: 246330
			[Token(Token = "0x403C23A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C23B RID: 246331
			[Token(Token = "0x403C23B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403C23C RID: 246332
			[Token(Token = "0x403C23C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
