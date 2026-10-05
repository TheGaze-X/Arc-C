using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F9A RID: 20378
	[Token(Token = "0x2004F9A")]
	public class EnemyDuelEntryTimeLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E4AB RID: 124075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4AB")]
		[Address(RVA = "0x1801EA0", Offset = "0x1800AA0", VA = "0x181801EA0")]
		public void Play()
		{
		}

		// Token: 0x0601E4AC RID: 124076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4AC")]
		[Address(RVA = "0x1802110", Offset = "0x1800D10", VA = "0x181802110")]
		public void Stop()
		{
		}

		// Token: 0x0601E4AD RID: 124077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4AD")]
		[Address(RVA = "0x1802360", Offset = "0x1800F60", VA = "0x181802360")]
		private void _StopTweenIfNeeded()
		{
		}

		// Token: 0x0601E4AE RID: 124078 RVA: 0x000AE198 File Offset: 0x000AC398
		[Token(Token = "0x601E4AE")]
		[Address(RVA = "0x1802170", Offset = "0x1800D70", VA = "0x181802170")]
		private float _GetVal()
		{
			return 0f;
		}

		// Token: 0x0601E4AF RID: 124079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4AF")]
		[Address(RVA = "0x18021D0", Offset = "0x1800DD0", VA = "0x1818021D0")]
		private void _SetVal(float val)
		{
		}

		// Token: 0x0601E4B0 RID: 124080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B0")]
		[Address(RVA = "0x18023F0", Offset = "0x1800FF0", VA = "0x1818023F0")]
		public EnemyDuelEntryTimeLineView()
		{
		}

		// Token: 0x040286EB RID: 165611
		[Token(Token = "0x40286EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _fromVal;

		// Token: 0x040286EC RID: 165612
		[Token(Token = "0x40286EC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _toVal;

		// Token: 0x040286ED RID: 165613
		[Token(Token = "0x40286ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _currTextUp;

		// Token: 0x040286EE RID: 165614
		[Token(Token = "0x40286EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _currTextDown;

		// Token: 0x040286EF RID: 165615
		[Token(Token = "0x40286EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _timeLineAnim;

		// Token: 0x040286F0 RID: 165616
		[Token(Token = "0x40286F0")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_animTween;

		// Token: 0x040286F1 RID: 165617
		[Token(Token = "0x40286F1")]
		[FieldOffset(Offset = "0x48")]
		private float m_animVal;

		// Token: 0x040286F2 RID: 165618
		[Token(Token = "0x40286F2")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_animTarget;

		// Token: 0x040286F3 RID: 165619
		[Token(Token = "0x40286F3")]
		[FieldOffset(Offset = "0x58")]
		private AnimationWrapper.AnimationHandler m_animHandler;

		// Token: 0x040286F4 RID: 165620
		[Token(Token = "0x40286F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x040286F5 RID: 165621
		[Token(Token = "0x40286F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x040286F6 RID: 165622
		[Token(Token = "0x40286F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StopTweenIfNeeded;

		// Token: 0x040286F7 RID: 165623
		[Token(Token = "0x40286F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetVal;

		// Token: 0x040286F8 RID: 165624
		[Token(Token = "0x40286F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetVal;

		// Token: 0x040286F9 RID: 165625
		[Token(Token = "0x40286F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
