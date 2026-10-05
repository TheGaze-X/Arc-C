using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007176 RID: 29046
	[Token(Token = "0x2007176")]
	public class Act9D0NewsGroupAdapter : RecycleLoopScrollAdapter<NewsObjViewHolder, Act9D0NewsViewModel>, IHotfixable
	{
		// Token: 0x060293B8 RID: 168888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60293B8")]
		[Address(RVA = "0x249E120", Offset = "0x249CD20", VA = "0x18249E120", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x060293B9 RID: 168889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293B9")]
		[Address(RVA = "0x249DF80", Offset = "0x249CB80", VA = "0x18249DF80", Slot = "13")]
		public override void UpdateView(int position, GameObject view, NewsObjViewHolder holder, Act9D0NewsViewModel data)
		{
		}

		// Token: 0x060293BA RID: 168890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293BA")]
		[Address(RVA = "0x249E1D0", Offset = "0x249CDD0", VA = "0x18249E1D0")]
		public Act9D0NewsGroupAdapter()
		{
		}

		// Token: 0x0403AE22 RID: 241186
		[Token(Token = "0x403AE22")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _newsObjPrefab;

		// Token: 0x0403AE23 RID: 241187
		[Token(Token = "0x403AE23")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _onNewsObjClicked;

		// Token: 0x0403AE24 RID: 241188
		[Token(Token = "0x403AE24")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public string cachedNewsChosenId;

		// Token: 0x0403AE25 RID: 241189
		[Token(Token = "0x403AE25")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public string cachedActId;

		// Token: 0x0403AE26 RID: 241190
		[Token(Token = "0x403AE26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403AE27 RID: 241191
		[Token(Token = "0x403AE27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403AE28 RID: 241192
		[Token(Token = "0x403AE28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
