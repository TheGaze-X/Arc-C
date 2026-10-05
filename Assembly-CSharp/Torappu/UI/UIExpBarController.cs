using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039F7 RID: 14839
	[Token(Token = "0x20039F7")]
	public class UIExpBarController
	{
		// Token: 0x060176CD RID: 95949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176CD")]
		[Address(RVA = "0xFC31B0", Offset = "0xFC1DB0", VA = "0x180FC31B0")]
		public UIExpBarController(UIExpBar expBar, UIExpBarController.ControlModel controlModel)
		{
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x060176CE RID: 95950 RVA: 0x00096660 File Offset: 0x00094860
		[Token(Token = "0x1700381B")]
		public bool isTweening
		{
			[Token(Token = "0x60176CE")]
			[Address(RVA = "0xFC3320", Offset = "0xFC1F20", VA = "0x180FC3320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060176CF RID: 95951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176CF")]
		[Address(RVA = "0xFC2D00", Offset = "0xFC1900", VA = "0x180FC2D00")]
		public void SetToStart()
		{
		}

		// Token: 0x060176D0 RID: 95952 RVA: 0x00096678 File Offset: 0x00094878
		[Token(Token = "0x60176D0")]
		[Address(RVA = "0xFC2DD0", Offset = "0xFC19D0", VA = "0x180FC2DD0")]
		public int TweenAddExpTo(int level, int exp)
		{
			return 0;
		}

		// Token: 0x060176D1 RID: 95953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176D1")]
		[Address(RVA = "0xFC2F40", Offset = "0xFC1B40", VA = "0x180FC2F40")]
		private IEnumerator TweenTo(int lvlAdditive)
		{
			return null;
		}

		// Token: 0x060176D2 RID: 95954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176D2")]
		[Address(RVA = "0xFC29D0", Offset = "0xFC15D0", VA = "0x180FC29D0")]
		public void Render(float levelProc)
		{
		}

		// Token: 0x060176D3 RID: 95955 RVA: 0x00096690 File Offset: 0x00094890
		[Token(Token = "0x60176D3")]
		[Address(RVA = "0xFC2FC0", Offset = "0xFC1BC0", VA = "0x180FC2FC0")]
		private float _ConvertToProc(int level, int exp)
		{
			return 0f;
		}

		// Token: 0x060176D4 RID: 95956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176D4")]
		[Address(RVA = "0xFC3070", Offset = "0xFC1C70", VA = "0x180FC3070")]
		private void _SetToMaxLevel()
		{
		}

		// Token: 0x0401C4C7 RID: 115911
		[Token(Token = "0x401C4C7")]
		private const float TWEEN_DURATION_PER_LEVEL = 0.3f;

		// Token: 0x0401C4C8 RID: 115912
		[Token(Token = "0x401C4C8")]
		private const float TWEEN_DURATION_MIN = 0.6f;

		// Token: 0x0401C4C9 RID: 115913
		[Token(Token = "0x401C4C9")]
		[FieldOffset(Offset = "0x10")]
		private Tween m_tweener;

		// Token: 0x0401C4CA RID: 115914
		[Token(Token = "0x401C4CA")]
		[FieldOffset(Offset = "0x18")]
		private float m_tweenProc;

		// Token: 0x0401C4CB RID: 115915
		[Token(Token = "0x401C4CB")]
		[FieldOffset(Offset = "0x1C")]
		private int m_targetLevel;

		// Token: 0x0401C4CC RID: 115916
		[Token(Token = "0x401C4CC")]
		[FieldOffset(Offset = "0x20")]
		private int m_targetExp;

		// Token: 0x0401C4CD RID: 115917
		[Token(Token = "0x401C4CD")]
		[FieldOffset(Offset = "0x28")]
		private UIExpBarController.ControlModel m_controlModel;

		// Token: 0x0401C4CE RID: 115918
		[Token(Token = "0x401C4CE")]
		[FieldOffset(Offset = "0x30")]
		private UIExpBar m_expBar;

		// Token: 0x0401C4CF RID: 115919
		[Token(Token = "0x401C4CF")]
		[FieldOffset(Offset = "0x38")]
		private UIExpBarController.LevelModel m_levelModelCache;

		// Token: 0x0401C4D0 RID: 115920
		[Token(Token = "0x401C4D0")]
		private const int PROGRESS = 50;

		// Token: 0x020039F8 RID: 14840
		[Token(Token = "0x20039F8")]
		public struct LevelModel
		{
			// Token: 0x0401C4D1 RID: 115921
			[Token(Token = "0x401C4D1")]
			[FieldOffset(Offset = "0x0")]
			public int level;

			// Token: 0x0401C4D2 RID: 115922
			[Token(Token = "0x401C4D2")]
			[FieldOffset(Offset = "0x4")]
			public int exp;
		}

		// Token: 0x020039F9 RID: 14841
		[Token(Token = "0x20039F9")]
		public class ControlModel : IHotfixable
		{
			// Token: 0x060176D5 RID: 95957 RVA: 0x000966A8 File Offset: 0x000948A8
			[Token(Token = "0x60176D5")]
			[Address(RVA = "0xFB0F40", Offset = "0xFAFB40", VA = "0x180FB0F40")]
			public UIExpBarController.LevelModel GetLevelModel(int level)
			{
				return default(UIExpBarController.LevelModel);
			}

			// Token: 0x060176D6 RID: 95958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60176D6")]
			[Address(RVA = "0xFB0FF0", Offset = "0xFAFBF0", VA = "0x180FB0FF0")]
			public ControlModel()
			{
			}

			// Token: 0x0401C4D3 RID: 115923
			[Token(Token = "0x401C4D3")]
			[FieldOffset(Offset = "0x10")]
			public int startLevel;

			// Token: 0x0401C4D4 RID: 115924
			[Token(Token = "0x401C4D4")]
			[FieldOffset(Offset = "0x14")]
			public int startExp;

			// Token: 0x0401C4D5 RID: 115925
			[Token(Token = "0x401C4D5")]
			[FieldOffset(Offset = "0x18")]
			public int maxLevel;

			// Token: 0x0401C4D6 RID: 115926
			[Token(Token = "0x401C4D6")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<int, UIExpBarController.LevelModel> levelMap;

			// Token: 0x0401C4D7 RID: 115927
			[Token(Token = "0x401C4D7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetLevelModel;

			// Token: 0x0401C4D8 RID: 115928
			[Token(Token = "0x401C4D8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
