using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002139 RID: 8505
	[Token(Token = "0x2002139")]
	public abstract class SpineAnimatorEffect : IHotfixable
	{
		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600D124 RID: 53540
		[Token(Token = "0x17001904")]
		public abstract SpineAnimatorEffectType EffectType { [Token(Token = "0x600D124")] get; }

		// Token: 0x0600D125 RID: 53541
		[Token(Token = "0x600D125")]
		public abstract void Apply(SpineAnimator animator, IFaceConfiguration face, SpineAnimatorEffect.Param param);

		// Token: 0x0600D126 RID: 53542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D126")]
		[Address(RVA = "0x3537CF0", Offset = "0x35368F0", VA = "0x183537CF0")]
		protected SpineAnimatorEffect()
		{
		}

		// Token: 0x0400DF9D RID: 57245
		[Token(Token = "0x400DF9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200213A RID: 8506
		[Token(Token = "0x200213A")]
		public struct Param : IDisposable
		{
			// Token: 0x0600D127 RID: 53543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D127")]
			[Address(RVA = "0x35368C0", Offset = "0x35354C0", VA = "0x1835368C0")]
			private void _CheckParams()
			{
			}

			// Token: 0x0600D128 RID: 53544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D128")]
			[Address(RVA = "0x3536720", Offset = "0x3535320", VA = "0x183536720", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600D129 RID: 53545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D129")]
			[Address(RVA = "0x3536760", Offset = "0x3535360", VA = "0x183536760")]
			public void SetFloatParam(string key, float value)
			{
			}

			// Token: 0x0600D12A RID: 53546 RVA: 0x0004B648 File Offset: 0x00049848
			[Token(Token = "0x600D12A")]
			[Address(RVA = "0x3536830", Offset = "0x3535430", VA = "0x183536830")]
			public readonly bool TryGetFloat(string key, out float value)
			{
				return default(bool);
			}

			// Token: 0x0400DF9E RID: 57246
			[Token(Token = "0x400DF9E")]
			[FieldOffset(Offset = "0x0")]
			public SpineAnimatorEffectType effectType;

			// Token: 0x0400DF9F RID: 57247
			[Token(Token = "0x400DF9F")]
			[FieldOffset(Offset = "0x8")]
			public string faceKey;

			// Token: 0x0400DFA0 RID: 57248
			[Token(Token = "0x400DFA0")]
			[FieldOffset(Offset = "0x10")]
			public int materialIndex;

			// Token: 0x0400DFA1 RID: 57249
			[Token(Token = "0x400DFA1")]
			[FieldOffset(Offset = "0x18")]
			private GenericPool<Dictionary<string, float>>.Ref floatParamsRef;
		}
	}
}
