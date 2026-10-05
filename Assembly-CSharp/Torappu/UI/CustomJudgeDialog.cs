using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003693 RID: 13971
	[Token(Token = "0x2003693")]
	public class CustomJudgeDialog : UICompDialog<CustomJudgeDialog.Input>
	{
		// Token: 0x06016388 RID: 91016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016388")]
		[Address(RVA = "0xEADDF0", Offset = "0xEAC9F0", VA = "0x180EADDF0", Slot = "18")]
		protected override void OnRender(CustomJudgeDialog.Input input)
		{
		}

		// Token: 0x06016389 RID: 91017 RVA: 0x00090078 File Offset: 0x0008E278
		[Token(Token = "0x6016389")]
		[Address(RVA = "0xEADD90", Offset = "0xEAC990", VA = "0x180EADD90", Slot = "8")]
		protected override bool IgnoreTimeScale()
		{
			return default(bool);
		}

		// Token: 0x0601638A RID: 91018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601638A")]
		[Address(RVA = "0xEAE2E0", Offset = "0xEACEE0", VA = "0x180EAE2E0")]
		private void _InitViewIfNeed(string customPrefabPath)
		{
		}

		// Token: 0x0601638B RID: 91019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601638B")]
		[Address(RVA = "0xEADD30", Offset = "0xEAC930", VA = "0x180EADD30", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601638C RID: 91020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601638C")]
		[Address(RVA = "0xEAE0C0", Offset = "0xEACCC0", VA = "0x180EAE0C0")]
		private void _EventOnCancel()
		{
		}

		// Token: 0x0601638D RID: 91021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601638D")]
		[Address(RVA = "0xEAE1D0", Offset = "0xEACDD0", VA = "0x180EAE1D0")]
		private void _EventOnConfirm()
		{
		}

		// Token: 0x0601638E RID: 91022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601638E")]
		[Address(RVA = "0xEAE580", Offset = "0xEAD180", VA = "0x180EAE580")]
		public CustomJudgeDialog()
		{
		}

		// Token: 0x0601638F RID: 91023 RVA: 0x00090090 File Offset: 0x0008E290
		[Token(Token = "0x601638F")]
		[Address(RVA = "0xEAE0B0", Offset = "0xEACCB0", VA = "0x180EAE0B0")]
		private bool <>xLuaBaseProxy_IgnoreTimeScale()
		{
			return default(bool);
		}

		// Token: 0x06016390 RID: 91024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016390")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0401AB28 RID: 109352
		[Token(Token = "0x401AB28")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0401AB29 RID: 109353
		[Token(Token = "0x401AB29")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0401AB2A RID: 109354
		[Token(Token = "0x401AB2A")]
		[FieldOffset(Offset = "0x80")]
		private CustomJudgeDialogView m_judgeView;

		// Token: 0x0401AB2B RID: 109355
		[Token(Token = "0x401AB2B")]
		[FieldOffset(Offset = "0x88")]
		private ValueBundle m_customVal;

		// Token: 0x0401AB2C RID: 109356
		[Token(Token = "0x401AB2C")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x0401AB2D RID: 109357
		[Token(Token = "0x401AB2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401AB2E RID: 109358
		[Token(Token = "0x401AB2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IgnoreTimeScale;

		// Token: 0x0401AB2F RID: 109359
		[Token(Token = "0x401AB2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitViewIfNeed;

		// Token: 0x0401AB30 RID: 109360
		[Token(Token = "0x401AB30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401AB31 RID: 109361
		[Token(Token = "0x401AB31")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnCancel;

		// Token: 0x0401AB32 RID: 109362
		[Token(Token = "0x401AB32")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnConfirm;

		// Token: 0x0401AB33 RID: 109363
		[Token(Token = "0x401AB33")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003694 RID: 13972
		[Token(Token = "0x2003694")]
		public class Input
		{
			// Token: 0x06016391 RID: 91025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016391")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0401AB34 RID: 109364
			[Token(Token = "0x401AB34")]
			[FieldOffset(Offset = "0x10")]
			public string customPrefabPath;

			// Token: 0x0401AB35 RID: 109365
			[Token(Token = "0x401AB35")]
			[FieldOffset(Offset = "0x18")]
			public ValueBundle customVal;
		}

		// Token: 0x02003695 RID: 13973
		[Token(Token = "0x2003695")]
		public class Output
		{
			// Token: 0x06016392 RID: 91026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016392")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x0401AB36 RID: 109366
			[Token(Token = "0x401AB36")]
			[FieldOffset(Offset = "0x10")]
			public bool isConfirm;

			// Token: 0x0401AB37 RID: 109367
			[Token(Token = "0x401AB37")]
			[FieldOffset(Offset = "0x18")]
			public ValueBundle customVal;
		}
	}
}
