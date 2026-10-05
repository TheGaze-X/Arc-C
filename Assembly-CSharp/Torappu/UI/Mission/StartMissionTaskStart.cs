using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Mission
{
	// Token: 0x020048B7 RID: 18615
	[Token(Token = "0x20048B7")]
	public class StartMissionTaskStart : MonoBehaviour
	{
		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x0601C158 RID: 115032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042A6")]
		public string taskId
		{
			[Token(Token = "0x601C158")]
			[Address(RVA = "0x15755C0", Offset = "0x15741C0", VA = "0x1815755C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C159 RID: 115033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C159")]
		[Address(RVA = "0x1575280", Offset = "0x1573E80", VA = "0x181575280")]
		public void ApplyMission()
		{
		}

		// Token: 0x0601C15A RID: 115034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C15A")]
		[Address(RVA = "0x15752C0", Offset = "0x1573EC0", VA = "0x1815752C0")]
		private void _FetchMaxLength()
		{
		}

		// Token: 0x0601C15B RID: 115035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C15B")]
		[Address(RVA = "0x1575330", Offset = "0x1573F30", VA = "0x181575330")]
		private IEnumerator _UpdateProgressBarLengthCoroutine()
		{
			return null;
		}

		// Token: 0x0601C15C RID: 115036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C15C")]
		[Address(RVA = "0x15753A0", Offset = "0x1573FA0", VA = "0x1815753A0")]
		private void _UpdateProgressBarLength()
		{
		}

		// Token: 0x0601C15D RID: 115037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C15D")]
		[Address(RVA = "0x1574D40", Offset = "0x1573940", VA = "0x181574D40")]
		public void ApplyData(MissionViewModel missionData, [Optional] Transform maskContainer)
		{
		}

		// Token: 0x0601C15E RID: 115038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C15E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StartMissionTaskStart()
		{
		}

		// Token: 0x04024B33 RID: 150323
		[Token(Token = "0x4024B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MissionProgressBar _progressState;

		// Token: 0x04024B34 RID: 150324
		[Token(Token = "0x4024B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _missionCurValueLabel;

		// Token: 0x04024B35 RID: 150325
		[Token(Token = "0x4024B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _missionTargetValueLabel;

		// Token: 0x04024B36 RID: 150326
		[Token(Token = "0x4024B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _finished;

		// Token: 0x04024B37 RID: 150327
		[Token(Token = "0x4024B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _unfinished;

		// Token: 0x04024B38 RID: 150328
		[Token(Token = "0x4024B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _confirmed;

		// Token: 0x04024B39 RID: 150329
		[Token(Token = "0x4024B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _descriptiontexts;

		// Token: 0x04024B3A RID: 150330
		[Token(Token = "0x4024B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text[] _rewardtexts;

		// Token: 0x04024B3B RID: 150331
		[Token(Token = "0x4024B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _hotSpot;

		// Token: 0x04024B3C RID: 150332
		[Token(Token = "0x4024B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MissionRewardPreviewItem _rewardItem;

		// Token: 0x04024B3D RID: 150333
		[Token(Token = "0x4024B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _maxProgressBarAndNumberLength;

		// Token: 0x04024B3E RID: 150334
		[Token(Token = "0x4024B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _progressBarAndNumberPadding;

		// Token: 0x04024B3F RID: 150335
		[Token(Token = "0x4024B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text[] _progressBarRightTexts;

		// Token: 0x04024B40 RID: 150336
		[Token(Token = "0x4024B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_maxProgressBarLength;

		// Token: 0x04024B41 RID: 150337
		[Token(Token = "0x4024B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool m_maxLengthFetched;

		// Token: 0x04024B42 RID: 150338
		[Token(Token = "0x4024B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MissionViewModel m_dataCache;
	}
}
