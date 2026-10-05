using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007728 RID: 30504
	[Token(Token = "0x2007728")]
	public class Act1VHalfIdleCharAvatarAdapter : RecycleLoopScrollAdapter<Act1VHalfIdleCharAvatarAdapter.ViewHolder, Act1VHalfIdleCharAvatarViewModel>
	{
		// Token: 0x0602ADC3 RID: 175555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADC3")]
		[Address(RVA = "0x2695A40", Offset = "0x2694640", VA = "0x182695A40", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act1VHalfIdleCharAvatarAdapter.ViewHolder holder, Act1VHalfIdleCharAvatarViewModel data)
		{
		}

		// Token: 0x0602ADC4 RID: 175556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADC4")]
		[Address(RVA = "0x2695CA0", Offset = "0x26948A0", VA = "0x182695CA0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602ADC5 RID: 175557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADC5")]
		[Address(RVA = "0x2695D60", Offset = "0x2694960", VA = "0x182695D60")]
		public Act1VHalfIdleCharAvatarAdapter()
		{
		}

		// Token: 0x0403DC9D RID: 253085
		[Token(Token = "0x403DC9D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act1VHalfIdleCharAvatarView _avatarViewPrefab;

		// Token: 0x0403DC9E RID: 253086
		[Token(Token = "0x403DC9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403DC9F RID: 253087
		[Token(Token = "0x403DC9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403DCA0 RID: 253088
		[Token(Token = "0x403DCA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007729 RID: 30505
		[Token(Token = "0x2007729")]
		public class ViewHolder
		{
			// Token: 0x0602ADC6 RID: 175558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ADC6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403DCA1 RID: 253089
			[Token(Token = "0x403DCA1")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleCharAvatarView avatarView;
		}
	}
}
