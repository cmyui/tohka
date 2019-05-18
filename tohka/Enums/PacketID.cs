﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tohka.Enums
{
    public enum PacketIDs : short
    {
        Client_SendUserStatus = 0,
        Client_SendIrcMessage = 1,
        Client_Exit = 2,
        Client_RequestStatusUpdate = 3,
        Client_Pong = 4,
        Server_LoginResponse = 5,
        Server_CommandError = 6,
        Server_SendMessage = 7,
        Server_Ping = 8,
        Server_HandleIrcChangeUsername = 9,
        Server_HandleIrcQuit = 10,
        Server_HandleOsuUpdate = 11,
        Server_HandleUserQuit = 12,
        Server_SpectatorJoined = 13,
        Server_SpectatorLeft = 14,
        Server_SpectateFrames = 15,
        Client_StartSpectating = 16,
        Client_StopSpectating = 17,
        Client_SpectateFrames = 18,
        Server_VersionUpdate = 19,
        Client_ErrorReport = 20,
        Client_CantSpectate = 21,
        Server_SpectatorCantSpectate = 22,
        Server_GetAttention = 23,
        Server_Announce = 24,
        Client_SendIrcMessagePrivate = 25,
        Server_MatchUpdate = 26,
        Server_MatchNew = 27,
        Server_MatchDisband = 28,
        Client_LobbyPart = 29,
        Client_LobbyJoin = 30,
        Client_MatchCreate = 31,
        Client_MatchJoin = 32,
        Client_MatchPart = 33,
        Server_MatchJoinSuccess = 36,
        Server_MatchJoinFail = 37,
        Client_MatchChangeSlot = 38,
        Client_MatchReady = 39,
        Client_MatchLock = 40,
        Client_MatchChangeSettings = 41,
        Server_FellowSpectatorJoined = 42,
        Server_FellowSpectatorLeft = 43,
        Client_MatchStart = 44,
        Server_MatchStart = 46,
        Client_MatchScoreUpdate = 47,
        Server_MatchScoreUpdate = 48,
        Client_MatchComplete = 49,
        Server_MatchTransferHost = 50,
        Client_MatchChangeMods = 51,
        Client_MatchLoadComplete = 52,
        Server_MatchAllPlayersLoaded = 53,
        Client_MatchNoBeatmap = 54,
        Client_MatchNotReady = 55,
        Client_MatchFailed = 56,
        Server_MatchPlayerFailed = 57,
        Server_MatchComplete = 58,
        Client_MatchHasBeatmap = 59,
        Client_MatchSkipRequest = 60,
        Server_MatchSkip = 61,
        Server_Unauthorised = 62,
        Client_ChannelJoin = 63,
        Server_ChannelJoinSuccess = 64,
        Server_ChannelAvailable = 65,
        Server_ChannelRevoked = 66,
        Server_ChannelAvailableAutojoin = 67,
        Client_BeatmapInfoRequest = 68,
        Server_BeatmapInfoReply = 69,
        Client_MatchTransferHost = 70,
        Server_LoginPermissions = 71,
        Server_FriendsList = 72,
        Client_FriendAdd = 73,
        Client_FriendRemove = 74,
        Server_ProtocolNegotiation = 75,
        Server_TitleUpdate = 76,
        Client_MatchChangeTeam = 77,
        Client_ChannelLeave = 78,
        Client_ReceiveUpdates = 79,
        Server_Monitor = 80,
        Server_MatchPlayerSkipped = 81,
        Client_SetIrcAwayMessage = 82,
        Server_UserPresence = 83,
        Client_UserStatsRequest = 85,
        Server_Restart = 86,
        Client_Invite = 87,
        Server_Invite = 88,
        Server_ChannelListingComplete = 89,
        Client_MatchChangePassword = 90,
        Server_MatchChangePassword = 91,
        Server_BanInfo = 92,
        Client_SpecialMatchInfoRequest = 93,
        Server_UserSilenced = 94,
        Server_UserPresenceSingle = 95,
        Server_UserPresenceBundle = 96,
        Client_UserPresenceRequest = 97,
        Client_UserPresenceRequestAll = 98,
        Client_UserToggleBlockNonFriendPM = 99,
        Server_UserPMBlocked = 100,
        Server_TargetIsSilenced = 101,
        Server_VersionUpdateForced = 102,
        Server_SwitchServer = 103,
        Server_AccountRestricted = 104,
        Server_RTX = 105,
        Client_MatchAbort = 106,
        Server_SwitchTourneyServer = 107,
        Client_SpecialJoinMatchChannel = 108,
        Client_SpecialLeaveMatchChannel = 109,
    }
}
