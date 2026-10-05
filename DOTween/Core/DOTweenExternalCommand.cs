using System;
using System.Runtime.CompilerServices;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	public static class DOTweenExternalCommand
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public static event Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x3759F60", Offset = "0x3758B60", VA = "0x183759F60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x375A040", Offset = "0x3758C40", VA = "0x18375A040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x3759E80", Offset = "0x3758A80", VA = "0x183759E80")]
		internal static void Dispatch_SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}
	}
}
