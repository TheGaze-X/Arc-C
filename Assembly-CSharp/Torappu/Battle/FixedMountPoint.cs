using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200221A RID: 8730
	[Token(Token = "0x200221A")]
	public class FixedMountPoint : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600DBD2 RID: 56274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBD2")]
		[Address(RVA = "0x361EFF0", Offset = "0x361DBF0", VA = "0x18361EFF0")]
		public FixedMountPoint()
		{
		}

		// Token: 0x0400EDF4 RID: 60916
		[Token(Token = "0x400EDF4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _targetBone;

		// Token: 0x0400EDF5 RID: 60917
		[Token(Token = "0x400EDF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animation _animation;

		// Token: 0x0400EDF6 RID: 60918
		[Token(Token = "0x400EDF6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip _clip;

		// Token: 0x0400EDF7 RID: 60919
		[Token(Token = "0x400EDF7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _snapshotTime;

		// Token: 0x0400EDF8 RID: 60920
		[Token(Token = "0x400EDF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
