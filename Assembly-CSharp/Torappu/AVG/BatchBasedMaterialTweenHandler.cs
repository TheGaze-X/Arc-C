using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001E68 RID: 7784
	[Token(Token = "0x2001E68")]
	public class BatchBasedMaterialTweenHandler : IMaterialTweenHandler
	{
		// Token: 0x0600C103 RID: 49411 RVA: 0x00046F08 File Offset: 0x00045108
		[Token(Token = "0x600C103")]
		[Address(RVA = "0x33E7370", Offset = "0x33E5F70", VA = "0x1833E7370", Slot = "4")]
		public bool PlayTweens(Material mat, List<MaterialTweenParam> tweens, [Optional] Action onComplete)
		{
			return default(bool);
		}

		// Token: 0x0600C104 RID: 49412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C104")]
		[Address(RVA = "0x33E7CD0", Offset = "0x33E68D0", VA = "0x1833E7CD0")]
		private void TryFinishBatch(int matId)
		{
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C105")]
		[Address(RVA = "0x33E71C0", Offset = "0x33E5DC0", VA = "0x1833E71C0", Slot = "5")]
		public void KillAll(Material mat)
		{
		}

		// Token: 0x0600C106 RID: 49414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C106")]
		[Address(RVA = "0x33E7DA0", Offset = "0x33E69A0", VA = "0x1833E7DA0")]
		public BatchBasedMaterialTweenHandler()
		{
		}

		// Token: 0x0400C283 RID: 49795
		[Token(Token = "0x400C283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, BatchBasedMaterialTweenHandler.BatchData> m_activeBatches;

		// Token: 0x02001E69 RID: 7785
		[Token(Token = "0x2001E69")]
		private class BatchData
		{
			// Token: 0x0600C107 RID: 49415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C107")]
			[Address(RVA = "0x33E7E30", Offset = "0x33E6A30", VA = "0x1833E7E30")]
			public BatchData()
			{
			}

			// Token: 0x0400C284 RID: 49796
			[Token(Token = "0x400C284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int remainingTweens;

			// Token: 0x0400C285 RID: 49797
			[Token(Token = "0x400C285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onComplete;

			// Token: 0x0400C286 RID: 49798
			[Token(Token = "0x400C286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Tween> tweens;
		}
	}
}
