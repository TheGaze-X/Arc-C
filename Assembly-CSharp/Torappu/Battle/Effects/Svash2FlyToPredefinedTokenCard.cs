using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003263 RID: 12899
	[Token(Token = "0x2003263")]
	public class Svash2FlyToPredefinedTokenCard : Effect.Behaviour
	{
		// Token: 0x06014740 RID: 83776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014740")]
		[Address(RVA = "0xCB6810", Offset = "0xCB5410", VA = "0x180CB6810")]
		private void Update()
		{
		}

		// Token: 0x06014741 RID: 83777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014741")]
		[Address(RVA = "0xCB66E0", Offset = "0xCB52E0", VA = "0x180CB66E0", Slot = "7")]
		public override void OnRecycle()
		{
		}

		// Token: 0x06014742 RID: 83778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014742")]
		[Address(RVA = "0xCB6870", Offset = "0xCB5470", VA = "0x180CB6870")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06014743 RID: 83779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014743")]
		[Address(RVA = "0xCB6D00", Offset = "0xCB5900", VA = "0x180CB6D00")]
		public Svash2FlyToPredefinedTokenCard()
		{
		}

		// Token: 0x06014744 RID: 83780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014744")]
		[Address(RVA = "0xC9CBA0", Offset = "0xC9B7A0", VA = "0x180C9CBA0")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x040182AD RID: 98989
		[Token(Token = "0x40182AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PredefinedLocation _location;

		// Token: 0x040182AE RID: 98990
		[Token(Token = "0x40182AE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _duration;

		// Token: 0x040182AF RID: 98991
		[Token(Token = "0x40182AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x040182B0 RID: 98992
		[Token(Token = "0x40182B0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _endScale;

		// Token: 0x040182B1 RID: 98993
		[Token(Token = "0x40182B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _upwards;

		// Token: 0x040182B2 RID: 98994
		[Token(Token = "0x40182B2")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x040182B3 RID: 98995
		[Token(Token = "0x40182B3")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x040182B4 RID: 98996
		[Token(Token = "0x40182B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040182B5 RID: 98997
		[Token(Token = "0x40182B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x040182B6 RID: 98998
		[Token(Token = "0x40182B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040182B7 RID: 98999
		[Token(Token = "0x40182B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
