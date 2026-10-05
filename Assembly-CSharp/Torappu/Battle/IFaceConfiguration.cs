using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200212D RID: 8493
	[Token(Token = "0x200212D")]
	public interface IFaceConfiguration
	{
		// Token: 0x0600D09D RID: 53405
		[Token(Token = "0x600D09D")]
		SkeletonAnimation GetSkeleton();

		// Token: 0x0600D09E RID: 53406
		[Token(Token = "0x600D09E")]
		Transform GetFaceMountPointTransform(Entity.MountPointType mountPointType);

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600D09F RID: 53407
		[Token(Token = "0x170018EF")]
		Renderer renderer { [Token(Token = "0x600D09F")] get; }
	}
}
