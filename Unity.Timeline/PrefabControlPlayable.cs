using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class PrefabControlPlayable : PlayableBehaviour
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x58FCEB0", Offset = "0x58FBAB0", VA = "0x1858FCEB0")]
		public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform)
		{
			return default(ScriptPlayable<PrefabControlPlayable>);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x170000CA")]
		public GameObject prefabInstance
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x58FD000", Offset = "0x58FBC00", VA = "0x1858FD000")]
		public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform)
		{
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x58FD410", Offset = "0x58FC010", VA = "0x1858FD410", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x58FD390", Offset = "0x58FBF90", VA = "0x1858FD390", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x58FD2F0", Offset = "0x58FBEF0", VA = "0x1858FD2F0", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x58FD4C0", Offset = "0x58FC0C0", VA = "0x1858FD4C0")]
		private static void SetHideFlagsRecursive(GameObject gameObject)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public PrefabControlPlayable()
		{
		}

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x10")]
		private GameObject m_Instance;
	}
}
