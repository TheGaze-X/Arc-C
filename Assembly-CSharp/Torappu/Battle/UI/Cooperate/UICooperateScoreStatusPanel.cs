using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033ED RID: 13293
	[Token(Token = "0x20033ED")]
	public class UICooperateScoreStatusPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015369 RID: 86889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015369")]
		[Address(RVA = "0xDA8F20", Offset = "0xDA7B20", VA = "0x180DA8F20")]
		public void UpdateScoreInfo(int[] scoreInfo)
		{
		}

		// Token: 0x0601536A RID: 86890 RVA: 0x0008AAE0 File Offset: 0x00088CE0
		[Token(Token = "0x601536A")]
		[Address(RVA = "0xDA9180", Offset = "0xDA7D80", VA = "0x180DA9180")]
		private bool _IsAllyScored(int[] scoreInfo)
		{
			return default(bool);
		}

		// Token: 0x0601536B RID: 86891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601536B")]
		[Address(RVA = "0xDA9220", Offset = "0xDA7E20", VA = "0x180DA9220")]
		public UICooperateScoreStatusPanel()
		{
		}

		// Token: 0x0401955C RID: 103772
		[Token(Token = "0x401955C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _allyScore;

		// Token: 0x0401955D RID: 103773
		[Token(Token = "0x401955D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _enemyScore;

		// Token: 0x0401955E RID: 103774
		[Token(Token = "0x401955E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _leadAnimGroup;

		// Token: 0x0401955F RID: 103775
		[Token(Token = "0x401955F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _leadAnim;

		// Token: 0x04019560 RID: 103776
		[Token(Token = "0x4019560")]
		[FieldOffset(Offset = "0x40")]
		private int[] m_cachedScoreInfo;

		// Token: 0x04019561 RID: 103777
		[Token(Token = "0x4019561")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateScoreInfo;

		// Token: 0x04019562 RID: 103778
		[Token(Token = "0x4019562")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsAllyScored;

		// Token: 0x04019563 RID: 103779
		[Token(Token = "0x4019563")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
