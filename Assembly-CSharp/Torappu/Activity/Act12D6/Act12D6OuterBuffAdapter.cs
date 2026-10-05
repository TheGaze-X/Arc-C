using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF4 RID: 31476
	[Token(Token = "0x2007AF4")]
	public class Act12D6OuterBuffAdapter : RecycleLoopScrollAdapter<BuffObjViewHolder, RoguelikeOuterBuff>, IHotfixable
	{
		// Token: 0x0602C13A RID: 180538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C13A")]
		[Address(RVA = "0x27F3FE0", Offset = "0x27F2BE0", VA = "0x1827F3FE0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, BuffObjViewHolder holder, RoguelikeOuterBuff data)
		{
		}

		// Token: 0x0602C13B RID: 180539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C13B")]
		[Address(RVA = "0x27F41D0", Offset = "0x27F2DD0", VA = "0x1827F41D0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602C13C RID: 180540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C13C")]
		[Address(RVA = "0x27F4280", Offset = "0x27F2E80", VA = "0x1827F4280")]
		public Act12D6OuterBuffAdapter()
		{
		}

		// Token: 0x0403FDF0 RID: 261616
		[Token(Token = "0x403FDF0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _outerBuffObj;

		// Token: 0x0403FDF1 RID: 261617
		[Token(Token = "0x403FDF1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _onOuterBuffDetailClicked;

		// Token: 0x0403FDF2 RID: 261618
		[Token(Token = "0x403FDF2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIStringEvent _onMaxLevelClicked;

		// Token: 0x0403FDF3 RID: 261619
		[Token(Token = "0x403FDF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403FDF4 RID: 261620
		[Token(Token = "0x403FDF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403FDF5 RID: 261621
		[Token(Token = "0x403FDF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
