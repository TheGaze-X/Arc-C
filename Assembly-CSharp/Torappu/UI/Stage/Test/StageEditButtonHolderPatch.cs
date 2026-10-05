using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stage.Test
{
	// Token: 0x02006A42 RID: 27202
	[Token(Token = "0x2006A42")]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(StageButtonOnMapHolder))]
	public class StageEditButtonHolderPatch : MonoBehaviour
	{
		// Token: 0x06026E26 RID: 159270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E26")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Init(IStageButtonPatchCollection source, StageButtonPatch patch)
		{
		}

		// Token: 0x06026E27 RID: 159271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E27")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Inspect]
		public void SaveToSource()
		{
		}

		// Token: 0x06026E28 RID: 159272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E28")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageEditButtonHolderPatch()
		{
		}

		// Token: 0x04036FC0 RID: 225216
		[Token(Token = "0x4036FC0")]
		private const string ERROR_RESOLVE_METHOD = "Plz try to reload the map to sync patch source.";

		// Token: 0x04036FC1 RID: 225217
		[Token(Token = "0x4036FC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private string _sourceAssetPath;

		// Token: 0x04036FC2 RID: 225218
		[Token(Token = "0x4036FC2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private string _sourceTypeName;

		// Token: 0x04036FC3 RID: 225219
		[Token(Token = "0x4036FC3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private StageButtonPatch _prevPatch;

		// Token: 0x04036FC4 RID: 225220
		[Token(Token = "0x4036FC4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("To which stage should the current patch line to.")]
		public string lineToStageId;
	}
}
