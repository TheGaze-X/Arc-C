using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003212 RID: 12818
	[Token(Token = "0x2003212")]
	public class BuffProgressFloatSource : AnimatorFloatSource
	{
		// Token: 0x06014567 RID: 83303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014567")]
		[Address(RVA = "0xC86500", Offset = "0xC85100", VA = "0x180C86500", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014568 RID: 83304 RVA: 0x000868E0 File Offset: 0x00084AE0
		[Token(Token = "0x6014568")]
		[Address(RVA = "0xC86040", Offset = "0xC84C40", VA = "0x180C86040", Slot = "10")]
		public override float GetValueOnPlay()
		{
			return 0f;
		}

		// Token: 0x06014569 RID: 83305 RVA: 0x000868F8 File Offset: 0x00084AF8
		[Token(Token = "0x6014569")]
		[Address(RVA = "0xC860A0", Offset = "0xC84CA0", VA = "0x180C860A0", Slot = "11")]
		public override float GetValue()
		{
			return 0f;
		}

		// Token: 0x0601456A RID: 83306 RVA: 0x00086910 File Offset: 0x00084B10
		[Token(Token = "0x601456A")]
		[Address(RVA = "0xC85DF0", Offset = "0xC849F0", VA = "0x180C85DF0")]
		public FP GetBlackboardProgress(Buff buff, string key, string maxKey)
		{
			return default(FP);
		}

		// Token: 0x0601456B RID: 83307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601456B")]
		[Address(RVA = "0xC86460", Offset = "0xC85060", VA = "0x180C86460", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601456C RID: 83308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601456C")]
		[Address(RVA = "0xC865A0", Offset = "0xC851A0", VA = "0x180C865A0", Slot = "7")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0601456D RID: 83309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601456D")]
		[Address(RVA = "0xC86660", Offset = "0xC85260", VA = "0x180C86660")]
		public BuffProgressFloatSource()
		{
		}

		// Token: 0x0601456E RID: 83310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601456E")]
		[Address(RVA = "0xC82030", Offset = "0xC80C30", VA = "0x180C82030")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601456F RID: 83311 RVA: 0x00086928 File Offset: 0x00084B28
		[Token(Token = "0x601456F")]
		[Address(RVA = "0xC84440", Offset = "0xC83040", VA = "0x180C84440")]
		private float <>xLuaBaseProxy_GetValueOnPlay()
		{
			return 0f;
		}

		// Token: 0x06014570 RID: 83312 RVA: 0x00086940 File Offset: 0x00084B40
		[Token(Token = "0x6014570")]
		[Address(RVA = "0xC844A0", Offset = "0xC830A0", VA = "0x180C844A0")]
		private float <>xLuaBaseProxy_GetValue()
		{
			return 0f;
		}

		// Token: 0x06014571 RID: 83313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014571")]
		[Address(RVA = "0xC81FD0", Offset = "0xC80BD0", VA = "0x180C81FD0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x06014572 RID: 83314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014572")]
		[Address(RVA = "0xC852F0", Offset = "0xC83EF0", VA = "0x180C852F0")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x04017FB5 RID: 98229
		[Token(Token = "0x4017FB5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04017FB6 RID: 98230
		[Token(Token = "0x4017FB6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _maxKey;

		// Token: 0x04017FB7 RID: 98231
		[Token(Token = "0x4017FB7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _progressKey;

		// Token: 0x04017FB8 RID: 98232
		[Token(Token = "0x4017FB8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _defaultVal;

		// Token: 0x04017FB9 RID: 98233
		[Token(Token = "0x4017FB9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _finishedVal;

		// Token: 0x04017FBA RID: 98234
		[Token(Token = "0x4017FBA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04017FBB RID: 98235
		[Token(Token = "0x4017FBB")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isFinished;

		// Token: 0x04017FBC RID: 98236
		[Token(Token = "0x4017FBC")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Buff> m_buff;

		// Token: 0x04017FBD RID: 98237
		[Token(Token = "0x4017FBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04017FBE RID: 98238
		[Token(Token = "0x4017FBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FBF RID: 98239
		[Token(Token = "0x4017FBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FC0 RID: 98240
		[Token(Token = "0x4017FC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlackboardProgress;

		// Token: 0x04017FC1 RID: 98241
		[Token(Token = "0x4017FC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04017FC2 RID: 98242
		[Token(Token = "0x4017FC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04017FC3 RID: 98243
		[Token(Token = "0x4017FC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
