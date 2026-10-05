using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF1 RID: 27377
	[Token(Token = "0x2006AF1")]
	public class ArchiveAchievementRarityCountView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027255 RID: 160341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027255")]
		[Address(RVA = "0x2251880", Offset = "0x2250480", VA = "0x182251880")]
		public void Render(Dictionary<int, AchievementRarityCountProgress> finishedCountDict, string formatOwn = "{0}", string formatTotal = "/{0}")
		{
		}

		// Token: 0x06027256 RID: 160342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027256")]
		[Address(RVA = "0x2251A80", Offset = "0x2250680", VA = "0x182251A80")]
		public ArchiveAchievementRarityCountView()
		{
		}

		// Token: 0x0403760A RID: 226826
		[Token(Token = "0x403760A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _raritySortId;

		// Token: 0x0403760B RID: 226827
		[Token(Token = "0x403760B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countOwn;

		// Token: 0x0403760C RID: 226828
		[Token(Token = "0x403760C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _countTotal;

		// Token: 0x0403760D RID: 226829
		[Token(Token = "0x403760D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403760E RID: 226830
		[Token(Token = "0x403760E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
