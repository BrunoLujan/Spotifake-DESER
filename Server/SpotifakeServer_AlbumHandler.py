import sys
import thriftpy
sys.path.append("../")
sys.path.append("gen-py")
from SpotifakeServices import AlbumService
from SpotifakeServices.ttypes import *
from SpotifakeManagement.ttypes import *
from SQLConnection.sqlServer_album import SqlServerAlbumManagement

class SpotifakeServerAlbumHandler(AlbumService.Iface):

    connection: SqlServerAlbumManagement = SqlServerAlbumManagement()
    spotifakeManagement_thrift = thriftpy.load('../Thrift/SpotifakeManagement.thrift', module_name='spotifakeManagement_thrift')
    spotifakeServices_thrift = thriftpy.load('../Thrift/SpotifakeServices.thrift', module_name='spotifakeServices_thrift')
    Date = spotifakeManagement_thrift.Date
    Album = spotifakeManagement_thrift.Album

    def __init__(self):
        pass

    def GetAlbumsByContentCreatorId(self, idContentCreator):
        albumList = []
        albumFound =  SqlServerAlbumManagement.GetAlbumsByContentCreatorId(self, idContentCreator)
        for n in albumFound:
            albumAux = Album()            
            albumAux.idAlbum = n.IdAlbum
            albumAux.title = n.title
            albumAux.coverPath = n.coverPath
            date = Date()
            date.day = n.releaseDate.day
            date.month = n.releaseDate.month
            date.year = n.releaseDate.year
            albumAux.releaseDate = date
            albumAux.gender = n.IdGenre
            albumAux.isSingle = n.type
            albumList.append(albumAux)
        return albumList

    def GetSinglesByContentCreatorId(self, idContentCreator):
        albumList = []
        albumFound =  SqlServerAlbumManagement.GetSinglesByContentCreatorId(self, idContentCreator)
        for n in albumFound:
            albumAux = Album()
            albumAux.idAlbum = n.IdAlbum
            albumAux.title = n.title
            albumAux.coverPath = n.coverPath
            date = Date()
            date.day = n.releaseDate.day
            date.month = n.releaseDate.month
            date.year = n.releaseDate.year
            albumAux.releaseDate = date
            albumAux.gender = n.IdGenre
            albumAux.isSingle = n.type
            albumList.append(albumAux)
        return albumList

    def GetAlbumByTitle(self, title):
        albumAux = Album()
        albumFound = SqlServerAlbumManagement.GetAlbumByTitle(self,title)
        albumAux.idAlbum = albumFound.IdAlbum
        albumAux.title = albumFound.title
        albumAux.coverPath = albumFound.coverPath
        date = Date()
        date.day = albumFound.releaseDate.day
        date.month = albumFound.releaseDate.month
        date.year = albumFound.releaseDate.year
        albumAux.releaseDate = date
        albumAux.gender = albumFound.IdGenre
        albumAux.isSingle = albumFound.type
        return albumFound

    def GetAlbumByLibraryId(self, idLibrary):
        albumList = []
        albumFound =  SqlServerAlbumManagement.GetAlbumByLibraryId(self, idLibrary)
        for n in albumFound:
            albumAux = Album()
            albumAux.idAlbum = n.IdAlbum
            albumAux.title = n.title
            albumAux.coverPath = n.coverPath
            date = Date()
            date.day = n.releaseDate.day
            date.month = n.releaseDate.month
            date.year = n.releaseDate.year
            albumAux.releaseDate = date
            albumAux.gender = n.IdGenre
            albumAux.isSingle = n.type
            albumList.append(albumAux)
        return albumList

    def AddAlbum(self, newAlbum, idContentCreator):
        idNewAlbum =  SqlServerAlbumManagement.AddAlbum(self, newAlbum, idContentCreator)
        return idNewAlbum

    def AddFeaturingAlbum(self, idNewAlbum, idContentCreator):
        SqlServerAlbumManagement.AddFeaturingAlbum(self, idNewAlbum, idContentCreator)
        return idNewAlbum

    def DeleteAlbum(self, idAlbum):
        albumFound = SqlServerAlbumManagement.DeleteAlbum(self, idAlbum)
        if (albumFound != None):
            return albumFound.idAlbum
        else:
            return SErrorNotFoundException("No existe el album")

    def UpdateAlbumTitle(self, idAlbum, newAlbumTitle):
        albumFound = SqlServerAlbumManagement.UpdateAlbumTitle(self, idAlbum, newAlbumTitle)
        return albumFound

    def UpdateAlbumCover(self,idAlbum, newStoragePath):
        albumId = SpotifakeServerAlbumManagement.UpdateAlbumCover(self, idAlbum, newStoragePath)
        return albumId

    def AddAlbumToLibrary(self, idLibrary, newAlbum):
        albumAux = Album()
        albumFound = SqlServerAlbumManagement.AddAlbumToLibrary(self, idLibrary, newAlbum)
        albumAux = Album()
        albumAux.idAlbum = albumFound.IdAlbum
        albumAux.title = albumFound.title
        albumAux.coverPath = albumFound.coverPath
        date = Date()
        date.day = albumFound.releaseDate.day
        date.month = albumFound.releaseDate.month
        date.year = albumFound.releaseDate.year
        albumAux.releaseDate = date
        albumAux.gender = albumFound.IdGenre
        albumAux.isSingle = albumFound.type
        return albumFound

    def DeleteLibraryAlbum(self,idLibrary, idAlbum):
        albumFound = SqlServerAlbumManagement.DeleteLibraryAlbum(self, idLibrary, idAlbum)
        return albumFound.idAlbum

    def GetAlbumByQuery(self, query):
        albumList = []
        albumFound =  SqlServerAlbumManagement.GetAlbumkByQuery(self, query)
        if self.connection.cursor.rowcount != 0:
                for n in albumFound:
                    album = Album(n.IdAlbum,n.coverPath,n.type,n.title,n.releaseDate)
                    album.contentCreator.idContentCreator = n.idContentCreator
                    album.contentCreator.stageName = n.ContentCreatorName
                    album.contentCreator.description = n.Description
                    album.contentCreator.imageStorgePath = n.imageStorgePath
                    album.gender.idGender = n.IdGenre
                    album.gender.name = n.name
                    albumList.append(album)
                return albumList        
        return False


