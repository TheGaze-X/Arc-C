using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtilityConstraint")]
	[RequireComponent(typeof(SkeletonUtilityBone))]
	[ExecuteAlways]
	public abstract class SkeletonUtilityConstraint : MonoBehaviour
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x4E9B720", Offset = "0x4E9A320", VA = "0x184E9B720", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x4E9B6C0", Offset = "0x4E9A2C0", VA = "0x184E9B6C0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000685 RID: 1669
		[Token(Token = "0x6000685")]
		public abstract void DoUpdate();

		// Token: 0x06000686 RID: 1670 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected SkeletonUtilityConstraint()
		{
		}

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x18")]
		protected SkeletonUtilityBone bone;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x20")]
		protected SkeletonUtility hierarchy;
	}
}
